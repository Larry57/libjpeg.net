using BitMiracle.LibJpeg.Classic;

namespace BitMiracle.cdJpeg
{
    /// <summary>
    /// cjpeg/djpeg may need to perform extra passes to convert to or from
    /// the source/destination file format.  The JPEG library does not know
    /// about these passes, but we'd like them to be counted by the progress
    /// monitor.  We use an expanded progress monitor object to hold the
    /// additional pass count.
    /// </summary>
    class cdjpeg_progress_mgr : jpeg_progress_mgr
    {
        public int completed_extra_passes; /* extra passes completed */
        public int total_extra_passes; /* total extra */
        /* last printed percentage stored here to avoid multiple printouts */
        //public int percent_done;
    }
}