﻿using System.ComponentModel.DataAnnotations;

namespace API_CRUDTareas.Models.Context
{
    /// <summary>
    /// Representa el modelo de tarea en el sistema de gestión de tareas.
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// Identificador único de la tarea.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Título de la tarea.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        /// <summary>
        /// Descripción opcional de la tarea.
        /// </summary>
        [MaxLength(100)]
        public string Description { get; set; }
        /// <summary>
        /// Indica si la tarea está completada o no.
        /// </summary>
        public bool IsCompleted { get; set; }


        // Campos de control
        /// <summary>
        /// Fecha y hora en que la tarea fue creada.
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Usuario que creó la tarea.
        /// </summary>
        [MaxLength(50)]
        public string UserCreated { get; set; }
        /// <summary>
        /// Fecha y hora en que la tarea fue modificada por última vez.
        /// </summary>
        public DateTime? DateModified { get; set; }
        /// <summary>
        /// Usuario que modificó la tarea por última vez.
        /// </summary>
        [MaxLength(50)]
        public string UserModified { get; set; }
        /// <summary>
        /// Nombre de la máquina donde se creó la tarea.
        /// </summary>
        [MaxLength(50)]
        public string MachineCreated { get; set; }
        /// <summary>
        /// Nombre de la máquina donde se modificó la tarea por última vez.
        /// </summary>
        [MaxLength(50)]
        public string MachineModified { get; set; }
    }
}
