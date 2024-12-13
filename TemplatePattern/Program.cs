using TemplatePattern;

StudentReportGenerator studentReportGenerator = new("PDF", "Текстовый редактор");
CourseReportGenerator courseReportGenerator = new("TXT", "Word2007");

studentReportGenerator.GenerateReport();
courseReportGenerator.GenerateReport();