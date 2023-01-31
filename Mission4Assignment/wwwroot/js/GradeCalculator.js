document.getElementById('calculate').addEventListener("click", function () {
    // determine final grade %
    var finalGrade;
    finalGrade =
        .5 * $('#assignments').val() +
        .1 * $('#group_projects').val() +
        .1 * $('#quizzes').val() +
        .1 * $('#midterm').val() +
        .1 * $('#final').val() +
        .1 * $('#intex').val();

    // determine letter grade
    var letterGrade;
    if (finalGrade >= 90) {
        letterGrade = 'A';
    } else if (finalGrade >= 80) {
        letterGrade = 'B';
    } else if (finalGrade >= 70) {
        letterGrade = 'C';
    } else if (finalGrade >= 60) {
        letterGrade = 'D';
    } else {
        letterGrade = 'E';
    }

    // display final grade
    document.getElementById('finalGrade').innerHTML = 'Final Grade: ' + finalGrade + '%\t(' + letterGrade + ')';
})
