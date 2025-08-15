namespace blackfinch_test.DataStore.Entities;

public class Decision
{
	public int ApplicationId { get; set; }
	public bool? IsApproved { get; set; }
	public DateTime SubmissionDate { get; set; }
	public DateTime ApprovalDate { get; set; }
}