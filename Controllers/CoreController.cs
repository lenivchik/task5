using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    public abstract class CoreController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        TRepository repository;

        public CoreController(TRepository Repository)
        {
            repository = Repository;
        }

        [HttpGet()]
        public IEnumerable<TEntity> Get()
        {
            return (IEnumerable<TEntity>)repository.Get();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int Id)
        {
            var Item = repository.Get(Id);

            if (Item == null)
            {
                return NotFound();
            }

            return new ObjectResult(Item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TEntity Item)
        {
            if (Item == null)
            {
                return BadRequest();
            }
            repository.Create(Item);
            return CreatedAtAction("Get", new { id = Item.Id }, Item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int Id, [FromBody] TEntity updatedItem)
        {
            if (updatedItem == null || updatedItem.Id != Id)
            {
                return BadRequest();
            }

            var Item = repository.Get(Id);
            if (Item == null)
            {
                return NotFound();
            }

            repository.Update(updatedItem);
            return CreatedAtAction("Get", Id );
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            var deletedItem = repository.Delete(Id);
            if (deletedItem == null)
            {
                return BadRequest();
            }

            return new ObjectResult(deletedItem);
        }
    }

}
