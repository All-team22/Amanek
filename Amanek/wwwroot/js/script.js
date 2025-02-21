document.addEventListener("DOMContentLoaded", function () {
    const steps = document.querySelectorAll(".step");
    const prevBtn = document.getElementById("prevBtn");
    const nextBtn = document.getElementById("nextBtn");
    const sidebarItems = document.querySelectorAll(".sidebar ul li"); // Select sidebar items
    const stepNumber = document.getElementById("stepNumber"); // Step number in heading

    let currentStep = 0;

    function updateForm() {
        steps.forEach((step, index) => {
            step.classList.toggle("active", index === currentStep);
        });
        stepNumber.textContent = currentStep + 1;
        sidebarItems.forEach((item, index) => {
            item.classList.toggle("active", index === currentStep);
        });

        prevBtn.disabled = currentStep === 0;
        nextBtn.textContent = currentStep === steps.length - 1 ? "Submit" : "Next";
    }

    nextBtn.addEventListener("click", function () {
        if (currentStep < steps.length - 1) {
            currentStep++;
            updateForm();
        } else {
            alert("Form Submitted!");
        }
    });

    prevBtn.addEventListener("click", function () {
        if (currentStep > 0) {
            currentStep--;
            updateForm();
        }
    });

    updateForm();
});

// ===================== Car Model Selection ======================
const carModels = {
    Toyota: ["Corolla", "Camry", "RAV4", "Highlander", "Yaris"],
    Honda: ["Civic", "Accord", "CR-V", "Pilot", "Fit"],
    Ford: ["Focus", "Fiesta", "Mustang", "Escape", "Explorer"],
    BMW: ["X5", "X3", "3 Series", "5 Series", "7 Series"],
    Mercedes: ["C-Class", "E-Class", "S-Class", "GLC", "GLE"],
    Nissan: ["Altima", "Sentra", "Maxima", "Rogue", "Murano"],
    Chevrolet: [
        "Malibu", "Impala", "Equinox", "Tahoe", "Camaro",
        "Suburban", "Silverado", "Traverse", "Trailblazer", "Blazer",
        "Spark", "Sonic", "Avalanche", "Cruze", "Corvette",
        "Optra", "Aveo"
    ],
    Hyundai: ["Elantra", "Sonata", "Tucson", "Santa Fe", "Kona"]
};

// Update Car Model Options Based on Selected Brand
document.getElementById("car-make").addEventListener("change", function () {
    const selectedBrand = this.value;
    const carModelSelect = document.getElementById("car-model");

    // Clear previous options
    carModelSelect.innerHTML = '<option value="" disabled selected>Select Car Model</option>';

    // Add new options
    if (carModels[selectedBrand]) {
        carModels[selectedBrand].forEach(model => {
            let option = document.createElement("option");
            option.value = model;
            option.textContent = model;
            carModelSelect.appendChild(option);
        });
    }
});
