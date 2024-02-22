using System.Collections;

class MeetingTimes
{
    public static List<List<int>> Merge(List<List<int>> meetingTimes)
    {

        List<List<int>> meetingTimesJagged = [[7, 8], [1, 5], [2, 4]];
        meetingTimes.Sort((meetingTime1, meetingTime2) => meetingTime1[0].CompareTo(meetingTime2[0]));
        List<List<int>> mergedMeetingTimes = [[meetingTimes[0][0], meetingTimes[0][1]]];
        for (var i = 1; i < meetingTimes.Count; i++)
        {
            if (mergedMeetingTimes.Last()[1] >= meetingTimes[i][0])
            {
                mergedMeetingTimes.Last()[1] = Math.Max(meetingTimes[i][1], mergedMeetingTimes.Last()[1]);
            }
            else
            {
                mergedMeetingTimes.Add([meetingTimes[i][0], meetingTimes[i][1]]);
            }
        }
        return mergedMeetingTimes;
    }

    public class MeetingTimesComparer : IComparer<int[]>
    {
        public int Compare(int[]? meetingTime1Object, int[]? meetingTime2Object)
        {
            if (meetingTime1Object == null || meetingTime2Object == null)
            {
                return 0;
            }
            int[] meetingTime1 = meetingTime1Object;
            int[] meetingTime2 = meetingTime2Object;
            return meetingTime1[0].CompareTo(meetingTime2[0]);
        }
    }
}