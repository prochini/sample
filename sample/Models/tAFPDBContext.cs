using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace sample.Models
{
    public partial class tAFPDBContext : DbContext
    {
        public tAFPDBContext()
        {
        }

        public tAFPDBContext(DbContextOptions<tAFPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MobiiUser> MobiiUsers { get; set; }
        public virtual DbSet<TappDealinfo> TappDealinfos { get; set; }
        public virtual DbSet<TappForminfopart1> TappForminfopart1s { get; set; }
        public virtual DbSet<TappForminfopart2> TappForminfopart2s { get; set; }
        public virtual DbSet<TappForminfopart3> TappForminfopart3s { get; set; }
        public virtual DbSet<TappIteminfopart1> TappIteminfopart1s { get; set; }
        public virtual DbSet<TappIteminfopart2> TappIteminfopart2s { get; set; }
        public virtual DbSet<TappIteminfopart3> TappIteminfopart3s { get; set; }
        public virtual DbSet<TappJoblist> TappJoblists { get; set; }
        public virtual DbSet<TappPayinfopart1> TappPayinfopart1s { get; set; }
        public virtual DbSet<TappPayinfopart2> TappPayinfopart2s { get; set; }
        public virtual DbSet<TappPayinfopart3> TappPayinfopart3s { get; set; }
        public virtual DbSet<TappReftable> TappReftables { get; set; }
        public virtual DbSet<TappReftablepart> TappReftableparts { get; set; }
        public virtual DbSet<TappServiceinfo> TappServiceinfos { get; set; }
        public virtual DbSet<TappServicesjoblist> TappServicesjoblists { get; set; }
        public virtual DbSet<TappSumpayinfopart1> TappSumpayinfopart1s { get; set; }
        public virtual DbSet<TappSumpayinfopart2> TappSumpayinfopart2s { get; set; }
        public virtual DbSet<TappSumpayinfopart3> TappSumpayinfopart3s { get; set; }
        public virtual DbSet<TappSystemlog> TappSystemlogs { get; set; }
        public virtual DbSet<TappTableinfo> TappTableinfos { get; set; }
        public virtual DbSet<TappUserlog> TappUserlogs { get; set; }
        public virtual DbSet<TappUserloginstate> TappUserloginstates { get; set; }
        public virtual DbSet<TappUseroperatelog> TappUseroperatelogs { get; set; }
        public virtual DbSet<TappUserreport> TappUserreports { get; set; }
        public virtual DbSet<TbaseApidatum> TbaseApidata { get; set; }
        public virtual DbSet<TbaseAttribute> TbaseAttributes { get; set; }
        public virtual DbSet<TbaseAttributevalue> TbaseAttributevalues { get; set; }
        public virtual DbSet<TbaseCachedatum> TbaseCachedata { get; set; }
        public virtual DbSet<TbaseCachemapping> TbaseCachemappings { get; set; }
        public virtual DbSet<TbaseCardgroup> TbaseCardgroups { get; set; }
        public virtual DbSet<TbaseCardgrouppart> TbaseCardgroupparts { get; set; }
        public virtual DbSet<TbaseComcredit1> TbaseComcredit1s { get; set; }
        public virtual DbSet<TbaseComcredit2> TbaseComcredit2s { get; set; }
        public virtual DbSet<TbaseComcredit3> TbaseComcredit3s { get; set; }
        public virtual DbSet<TbaseComcreditsum> TbaseComcreditsums { get; set; }
        public virtual DbSet<TbaseCompany> TbaseCompanies { get; set; }
        public virtual DbSet<TbaseDealstate> TbaseDealstates { get; set; }
        public virtual DbSet<TbaseDealtype> TbaseDealtypes { get; set; }
        public virtual DbSet<TbaseFilecenter> TbaseFilecenters { get; set; }
        public virtual DbSet<TbaseFtpdatum> TbaseFtpdata { get; set; }
        public virtual DbSet<TbaseJustkacmd> TbaseJustkacmds { get; set; }
        public virtual DbSet<TbaseListmap> TbaseListmaps { get; set; }
        public virtual DbSet<TbaseMenuinfo> TbaseMenuinfos { get; set; }
        public virtual DbSet<TbaseMenuoperate> TbaseMenuoperates { get; set; }
        public virtual DbSet<TbaseMenuuser> TbaseMenuusers { get; set; }
        public virtual DbSet<TbaseNoticelog> TbaseNoticelogs { get; set; }
        public virtual DbSet<TbasePayset> TbasePaysets { get; set; }
        public virtual DbSet<TbasePaysetitem> TbasePaysetitems { get; set; }
        public virtual DbSet<TbaseProdattr> TbaseProdattrs { get; set; }
        public virtual DbSet<TbaseProdlist> TbaseProdlists { get; set; }
        public virtual DbSet<TbaseProdlistattrmap> TbaseProdlistattrmaps { get; set; }
        public virtual DbSet<TbaseProduct> TbaseProducts { get; set; }
        public virtual DbSet<TbaseProductgiveaway> TbaseProductgiveaways { get; set; }
        public virtual DbSet<TbaseProductimg> TbaseProductimgs { get; set; }
        public virtual DbSet<TbaseProductlog> TbaseProductlogs { get; set; }
        public virtual DbSet<TbaseProductprodlist> TbaseProductprodlists { get; set; }
        public virtual DbSet<TbaseRoleinfo> TbaseRoleinfos { get; set; }
        public virtual DbSet<TbaseTabletype> TbaseTabletypes { get; set; }
        public virtual DbSet<TbaseUserauthstore1> TbaseUserauthstore1s { get; set; }
        public virtual DbSet<TbaseUserauthstore2> TbaseUserauthstore2s { get; set; }
        public virtual DbSet<TbaseUserauthstore3> TbaseUserauthstore3s { get; set; }
        public virtual DbSet<TbaseUsercardchangelog1> TbaseUsercardchangelog1s { get; set; }
        public virtual DbSet<TbaseUsercardchangelog2> TbaseUsercardchangelog2s { get; set; }
        public virtual DbSet<TbaseUsercardchangelog3> TbaseUsercardchangelog3s { get; set; }
        public virtual DbSet<TbaseUsercardlog1> TbaseUsercardlog1s { get; set; }
        public virtual DbSet<TbaseUsercardlog2> TbaseUsercardlog2s { get; set; }
        public virtual DbSet<TbaseUsercardlog3> TbaseUsercardlog3s { get; set; }
        public virtual DbSet<TbaseUserdefine> TbaseUserdefines { get; set; }
        public virtual DbSet<TbaseUserdevice> TbaseUserdevices { get; set; }
        public virtual DbSet<TbaseUserextcode> TbaseUserextcodes { get; set; }
        public virtual DbSet<TbaseUserfavourite1> TbaseUserfavourite1s { get; set; }
        public virtual DbSet<TbaseUserfavourite2> TbaseUserfavourite2s { get; set; }
        public virtual DbSet<TbaseUserfavourite3> TbaseUserfavourite3s { get; set; }
        public virtual DbSet<TbaseUserinfo> TbaseUserinfos { get; set; }
        public virtual DbSet<TbaseUserlevelinfo> TbaseUserlevelinfos { get; set; }
        public virtual DbSet<TbaseUsermission1> TbaseUsermission1s { get; set; }
        public virtual DbSet<TbaseUsermission2> TbaseUsermission2s { get; set; }
        public virtual DbSet<TbaseUsermission3> TbaseUsermission3s { get; set; }
        public virtual DbSet<TbaseUserpoint1> TbaseUserpoint1s { get; set; }
        public virtual DbSet<TbaseUserpoint2> TbaseUserpoint2s { get; set; }
        public virtual DbSet<TbaseUserpoint3> TbaseUserpoint3s { get; set; }
        public virtual DbSet<TbaseUserprofile> TbaseUserprofiles { get; set; }
        public virtual DbSet<TbaseUserrole> TbaseUserroles { get; set; }
        public virtual DbSet<TbaseUserspree1> TbaseUserspree1s { get; set; }
        public virtual DbSet<TbaseUserspree2> TbaseUserspree2s { get; set; }
        public virtual DbSet<TbaseUserspree3> TbaseUserspree3s { get; set; }
        public virtual DbSet<TbaseUserthird> TbaseUserthirds { get; set; }
        public virtual DbSet<TbaseUserticket1> TbaseUserticket1s { get; set; }
        public virtual DbSet<TbaseUserticket2> TbaseUserticket2s { get; set; }
        public virtual DbSet<TbaseUserticket3> TbaseUserticket3s { get; set; }
        public virtual DbSet<TbaseUserticketlog> TbaseUserticketlogs { get; set; }
        public virtual DbSet<TbaseUservoucher1> TbaseUservoucher1s { get; set; }
        public virtual DbSet<TbaseUservoucher2> TbaseUservoucher2s { get; set; }
        public virtual DbSet<TbaseUservoucher3> TbaseUservoucher3s { get; set; }
        public virtual DbSet<TbaseWorkflow> TbaseWorkflows { get; set; }
        public virtual DbSet<TbaseWorkflowpart> TbaseWorkflowparts { get; set; }
        public virtual DbSet<TecAuthstore> TecAuthstores { get; set; }
        public virtual DbSet<TecAuthstorepart> TecAuthstoreparts { get; set; }
        public virtual DbSet<TecCart> TecCarts { get; set; }
        public virtual DbSet<TecEclogistic> TecEclogistics { get; set; }
        public virtual DbSet<TecEclogisticspart> TecEclogisticsparts { get; set; }
        public virtual DbSet<TecEcstore> TecEcstores { get; set; }
        public virtual DbSet<TecEcstoreattr> TecEcstoreattrs { get; set; }
        public virtual DbSet<TecEcstoreexttype> TecEcstoreexttypes { get; set; }
        public virtual DbSet<TecEcstorelink> TecEcstorelinks { get; set; }
        public virtual DbSet<TecEcstorepart> TecEcstoreparts { get; set; }
        public virtual DbSet<TecEcstoreparttemp> TecEcstoreparttemps { get; set; }
        public virtual DbSet<TecEcstorepaymentmap> TecEcstorepaymentmaps { get; set; }
        public virtual DbSet<TecEcstoreprodlist> TecEcstoreprodlists { get; set; }
        public virtual DbSet<TecEcstoretemp> TecEcstoretemps { get; set; }
        public virtual DbSet<TecEcvoucher1> TecEcvoucher1s { get; set; }
        public virtual DbSet<TecEcvoucher2> TecEcvoucher2s { get; set; }
        public virtual DbSet<TecEcvoucher3> TecEcvoucher3s { get; set; }
        public virtual DbSet<TecEcvoucherview> TecEcvoucherviews { get; set; }
        public virtual DbSet<TerpApplyinfopart> TerpApplyinfoparts { get; set; }
        public virtual DbSet<TerpDeliveryorder> TerpDeliveryorders { get; set; }
        public virtual DbSet<TerpMainstore> TerpMainstores { get; set; }
        public virtual DbSet<TerpOrder> TerpOrders { get; set; }
        public virtual DbSet<TerpPoint> TerpPoints { get; set; }
        public virtual DbSet<TerpPointpart> TerpPointparts { get; set; }
        public virtual DbSet<TerpRefund> TerpRefunds { get; set; }
        public virtual DbSet<TerpReturngood> TerpReturngoods { get; set; }
        public virtual DbSet<TerpService> TerpServices { get; set; }
        public virtual DbSet<TerpShipper> TerpShippers { get; set; }
        public virtual DbSet<TerpSubstore> TerpSubstores { get; set; }
        public virtual DbSet<TerpVendingorder> TerpVendingorders { get; set; }
        public virtual DbSet<TerpVouapply> TerpVouapplies { get; set; }
        public virtual DbSet<TerpVouapplypart> TerpVouapplyparts { get; set; }
        public virtual DbSet<TerpVreimburse> TerpVreimburses { get; set; }
        public virtual DbSet<TjskUsereventfile> TjskUsereventfiles { get; set; }
        public virtual DbSet<TjskUsertag> TjskUsertags { get; set; }
        public virtual DbSet<TpayContractstore> TpayContractstores { get; set; }
        public virtual DbSet<TpayCspayment> TpayCspayments { get; set; }
        public virtual DbSet<TpayCspaymentpart> TpayCspaymentparts { get; set; }
        public virtual DbSet<TpayInvoice> TpayInvoices { get; set; }
        public virtual DbSet<TpayInvoicepart> TpayInvoiceparts { get; set; }
        public virtual DbSet<TpayPaymentflow> TpayPaymentflows { get; set; }
        public virtual DbSet<TpayPayorder> TpayPayorders { get; set; }
        public virtual DbSet<TpayPayorderlog> TpayPayorderlogs { get; set; }
        public virtual DbSet<TpayPfpayment> TpayPfpayments { get; set; }
        public virtual DbSet<TpayPfpaymentpart> TpayPfpaymentparts { get; set; }
        public virtual DbSet<TpayPgmember> TpayPgmembers { get; set; }
        public virtual DbSet<TpayPgorder> TpayPgorders { get; set; }
        public virtual DbSet<TpayPgorderlog> TpayPgorderlogs { get; set; }
        public virtual DbSet<TpaySetbasevalue> TpaySetbasevalues { get; set; }
        public virtual DbSet<TpntGame> TpntGames { get; set; }
        public virtual DbSet<TpntGamecondpart> TpntGamecondparts { get; set; }
        public virtual DbSet<TpntGamelog> TpntGamelogs { get; set; }
        public virtual DbSet<TpntGamepart> TpntGameparts { get; set; }
        public virtual DbSet<TpntMission> TpntMissions { get; set; }
        public virtual DbSet<TpntMissionjoblist> TpntMissionjoblists { get; set; }
        public virtual DbSet<TpntMissionlog> TpntMissionlogs { get; set; }
        public virtual DbSet<TpntMissionopertlog> TpntMissionopertlogs { get; set; }
        public virtual DbSet<TpntMissionpart> TpntMissionparts { get; set; }
        public virtual DbSet<TvouSpree> TvouSprees { get; set; }
        public virtual DbSet<TvouSpreepart> TvouSpreeparts { get; set; }
        public virtual DbSet<TvouVoucher> TvouVouchers { get; set; }
        public virtual DbSet<TvouVoucherad> TvouVoucherads { get; set; }
        public virtual DbSet<TvouVoucherattr> TvouVoucherattrs { get; set; }
        public virtual DbSet<TvouVouchergive> TvouVouchergives { get; set; }
        public virtual DbSet<TvouVoucherlimit> TvouVoucherlimits { get; set; }
        public virtual DbSet<TvouVouchermodel> TvouVouchermodels { get; set; }
        public virtual DbSet<TvouVoucherprodlist> TvouVoucherprodlists { get; set; }
        public virtual DbSet<TvouVoucherrange> TvouVoucherranges { get; set; }
        public virtual DbSet<TvouVoucherstore> TvouVoucherstores { get; set; }
        public virtual DbSet<TvouVouchervoulist> TvouVouchervoulists { get; set; }
        public virtual DbSet<TvouVouflashsale> TvouVouflashsales { get; set; }
        public virtual DbSet<TvouVouflashsalelog> TvouVouflashsalelogs { get; set; }
        public virtual DbSet<TvouVouflashsalepart> TvouVouflashsaleparts { get; set; }
        public virtual DbSet<TvouVoulist> TvouVoulists { get; set; }
        public virtual DbSet<TwebAdimg> TwebAdimgs { get; set; }
        public virtual DbSet<TwebFilesetting> TwebFilesettings { get; set; }
        public virtual DbSet<TwebFunction> TwebFunctions { get; set; }
        public virtual DbSet<TwebImessage> TwebImessages { get; set; }
        public virtual DbSet<TwebMsgcategory> TwebMsgcategories { get; set; }
        public virtual DbSet<TwebQuestioncontent> TwebQuestioncontents { get; set; }
        public virtual DbSet<TwebTravel> TwebTravels { get; set; }
        public virtual DbSet<TwebTravelattr> TwebTravelattrs { get; set; }
        public virtual DbSet<TwebTravelprodlist> TwebTravelprodlists { get; set; }
        public virtual DbSet<ViewCardlist> ViewCardlists { get; set; }
        public virtual DbSet<ViewIteminfopart> ViewIteminfoparts { get; set; }
        public virtual DbSet<ViewLatestpayorderlog> ViewLatestpayorderlogs { get; set; }
        public virtual DbSet<ViewLatestservice> ViewLatestservices { get; set; }
        public virtual DbSet<ViewUsermission> ViewUsermissions { get; set; }
        public virtual DbSet<ViewUservoucher> ViewUservouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=54.150.124.230;port=3306;user id=mysqlsa;password=2wsXCft6;database=tAFPDB;sslmode=None;pooling=false", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.21-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_unicode_520_ci");

            modelBuilder.Entity<MobiiUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("mobii_user");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasComment("主鍵");

                entity.Property(e => e.CrtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("crt_date")
                    .HasComment("資料建立日期");

                entity.Property(e => e.CrtUserId)
                    .HasColumnName("crt_user_id")
                    .HasComment("資料建立人員主鍵");

                entity.Property(e => e.CrtUserName)
                    .HasMaxLength(20)
                    .HasColumnName("crt_user_name")
                    .HasComment("資料建立人員名稱");

                entity.Property(e => e.IdentityAccessToken)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("identity_access_token")
                    .HasComment("艾斯身份識別中心所核發會員資料得access_token 用於獲取用戶授權使用的個人資料。");

                entity.Property(e => e.IdentityRefreshToken)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("identity_refresh_token")
                    .HasComment("更新 identity_access_token 時須持此項向艾斯身份識別中心刷新identity_access_token的期限");

                entity.Property(e => e.MdyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mdy_date")
                    .HasComment("資料修改日期");

                entity.Property(e => e.MdyUserId)
                    .HasMaxLength(32)
                    .HasColumnName("mdy_user_id")
                    .IsFixedLength(true)
                    .HasComment("資料修改人員主鍵");

                entity.Property(e => e.MdyUserName)
                    .HasMaxLength(20)
                    .HasColumnName("mdy_user_name")
                    .IsFixedLength(true)
                    .HasComment("資料修改人員名稱");

                entity.Property(e => e.TbaseUserinfoId)
                    .HasColumnName("tbase_userinfo_id")
                    .HasComment("mobii 一代會員資料主表的主鍵，tbase_userinfo.userinfo_id");

                entity.Property(e => e.UserAvatar)
                    .HasMaxLength(255)
                    .HasColumnName("user_avatar")
                    .HasComment("會員頭像網址，存放網址的相對路徑");

                entity.Property(e => e.UserBday)
                    .HasColumnType("date")
                    .HasColumnName("user_bday")
                    .HasComment("會員生日");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(255)
                    .HasColumnName("user_email")
                    .HasComment("會員的電子郵件位址");

                entity.Property(e => e.UserGender)
                    .HasMaxLength(10)
                    .HasColumnName("user_gender")
                    .HasComment("性別(MALE\\FEMALE\\ZIR)\n\nMALE: 男\n\nFEMALE: 女\n\nZIR: 會員不願透露 ");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("user_name")
                    .HasComment("會員顯示名稱");
            });

            modelBuilder.Entity<TappDealinfo>(entity =>
            {
                entity.HasKey(e => e.DealInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_dealinfo");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.DealInfoTableNo, "Index");

                entity.Property(e => e.DealInfoId).HasColumnName("DealInfo_ID");

                entity.Property(e => e.DealInfoActuallyPaidState).HasColumnName("DealInfo_ActuallyPaidState");

                entity.Property(e => e.DealInfoCompanyCode).HasColumnName("DealInfo_CompanyCode");

                entity.Property(e => e.DealInfoContent)
                    .HasColumnType("text")
                    .HasColumnName("DealInfo_Content");

                entity.Property(e => e.DealInfoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DealInfo_Date");

                entity.Property(e => e.DealInfoDealStateCode).HasColumnName("DealInfo_DealStateCode");

                entity.Property(e => e.DealInfoDealStateName)
                    .HasMaxLength(64)
                    .HasColumnName("DealInfo_DealStateName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealInfoDealStateShowName)
                    .HasMaxLength(64)
                    .HasColumnName("DealInfo_DealStateShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealInfoDealTypeCode).HasColumnName("DealInfo_DealTypeCode");

                entity.Property(e => e.DealInfoDealTypeName)
                    .HasMaxLength(64)
                    .HasColumnName("DealInfo_DealTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealInfoDealerCode).HasColumnName("DealInfo_DealerCode");

                entity.Property(e => e.DealInfoDealerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DealInfo_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealInfoDeliveryState).HasColumnName("DealInfo_DeliveryState");

                entity.Property(e => e.DealInfoFloatParamA).HasColumnName("DealInfo_FloatParamA");

                entity.Property(e => e.DealInfoFloatParamB).HasColumnName("DealInfo_FloatParamB");

                entity.Property(e => e.DealInfoInsertDealerCode).HasColumnName("DealInfo_InsertDealerCode");

                entity.Property(e => e.DealInfoIntParamA).HasColumnName("DealInfo_IntParamA");

                entity.Property(e => e.DealInfoIntParamB).HasColumnName("DealInfo_IntParamB");

                entity.Property(e => e.DealInfoIpaddress)
                    .HasColumnType("text")
                    .HasColumnName("DealInfo_IPAddress");

                entity.Property(e => e.DealInfoLockState).HasColumnName("DealInfo_LockState");

                entity.Property(e => e.DealInfoMainTableNo).HasColumnName("DealInfo_MainTableNo");

                entity.Property(e => e.DealInfoMemo)
                    .HasColumnType("text")
                    .HasColumnName("DealInfo_Memo");

                entity.Property(e => e.DealInfoPaymentState).HasColumnName("DealInfo_PaymentState");

                entity.Property(e => e.DealInfoRevenueState).HasColumnName("DealInfo_RevenueState");

                entity.Property(e => e.DealInfoShippingState).HasColumnName("DealInfo_ShippingState");

                entity.Property(e => e.DealInfoSyncState).HasColumnName("DealInfo_SyncState");

                entity.Property(e => e.DealInfoTableNo).HasColumnName("DealInfo_TableNo");

                entity.Property(e => e.DealInfoTableTypeCode).HasColumnName("DealInfo_TableTypeCode");

                entity.Property(e => e.DealInfoTableTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DealInfo_TableTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealInfoTableTypeWorkflowId).HasColumnName("DealInfo_TableTypeWorkflowID");

                entity.Property(e => e.DealInfoUpCompanyCode).HasColumnName("DealInfo_UpCompanyCode");

                entity.Property(e => e.DealInfoUpTableInfoModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DealInfo_UpTableInfoModifyDate");

                entity.Property(e => e.DealInfoUpTableInfoNo).HasColumnName("DealInfo_UpTableInfoNo");

                entity.Property(e => e.DealInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("DealInfo_VarParamA");

                entity.Property(e => e.DealInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("DealInfo_VarParamB");
            });

            modelBuilder.Entity<TappForminfopart1>(entity =>
            {
                entity.HasKey(e => e.FormInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_forminfopart1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.FormInfoPartTableNo, "Index");

                entity.Property(e => e.FormInfoPartId).HasColumnName("FormInfoPart_ID");

                entity.Property(e => e.FormInfoPartChildGroupNo).HasColumnName("FormInfoPart_ChildGroupNo");

                entity.Property(e => e.FormInfoPartChildTableNo).HasColumnName("FormInfoPart_ChildTableNo");

                entity.Property(e => e.FormInfoPartFloatParamA).HasColumnName("FormInfoPart_FloatParamA");

                entity.Property(e => e.FormInfoPartFloatParamB).HasColumnName("FormInfoPart_FloatParamB");

                entity.Property(e => e.FormInfoPartIntParamA).HasColumnName("FormInfoPart_IntParamA");

                entity.Property(e => e.FormInfoPartIntParamB).HasColumnName("FormInfoPart_IntParamB");

                entity.Property(e => e.FormInfoPartState).HasColumnName("FormInfoPart_State");

                entity.Property(e => e.FormInfoPartSyncState).HasColumnName("FormInfoPart_SyncState");

                entity.Property(e => e.FormInfoPartTableNo).HasColumnName("FormInfoPart_TableNo");

                entity.Property(e => e.FormInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("FormInfoPart_VarParamA");

                entity.Property(e => e.FormInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("FormInfoPart_VarParamB");
            });

            modelBuilder.Entity<TappForminfopart2>(entity =>
            {
                entity.HasKey(e => e.FormInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_forminfopart2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.FormInfoPartTableNo, "Index");

                entity.Property(e => e.FormInfoPartId).HasColumnName("FormInfoPart_ID");

                entity.Property(e => e.FormInfoPartChildGroupNo).HasColumnName("FormInfoPart_ChildGroupNo");

                entity.Property(e => e.FormInfoPartChildTableNo).HasColumnName("FormInfoPart_ChildTableNo");

                entity.Property(e => e.FormInfoPartFloatParamA).HasColumnName("FormInfoPart_FloatParamA");

                entity.Property(e => e.FormInfoPartFloatParamB).HasColumnName("FormInfoPart_FloatParamB");

                entity.Property(e => e.FormInfoPartIntParamA).HasColumnName("FormInfoPart_IntParamA");

                entity.Property(e => e.FormInfoPartIntParamB).HasColumnName("FormInfoPart_IntParamB");

                entity.Property(e => e.FormInfoPartState).HasColumnName("FormInfoPart_State");

                entity.Property(e => e.FormInfoPartSyncState).HasColumnName("FormInfoPart_SyncState");

                entity.Property(e => e.FormInfoPartTableNo).HasColumnName("FormInfoPart_TableNo");

                entity.Property(e => e.FormInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("FormInfoPart_VarParamA");

                entity.Property(e => e.FormInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("FormInfoPart_VarParamB");
            });

            modelBuilder.Entity<TappForminfopart3>(entity =>
            {
                entity.HasKey(e => e.FormInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_forminfopart3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.FormInfoPartTableNo, "Index");

                entity.Property(e => e.FormInfoPartId).HasColumnName("FormInfoPart_ID");

                entity.Property(e => e.FormInfoPartChildGroupNo).HasColumnName("FormInfoPart_ChildGroupNo");

                entity.Property(e => e.FormInfoPartChildTableNo).HasColumnName("FormInfoPart_ChildTableNo");

                entity.Property(e => e.FormInfoPartFloatParamA).HasColumnName("FormInfoPart_FloatParamA");

                entity.Property(e => e.FormInfoPartFloatParamB).HasColumnName("FormInfoPart_FloatParamB");

                entity.Property(e => e.FormInfoPartIntParamA).HasColumnName("FormInfoPart_IntParamA");

                entity.Property(e => e.FormInfoPartIntParamB).HasColumnName("FormInfoPart_IntParamB");

                entity.Property(e => e.FormInfoPartState).HasColumnName("FormInfoPart_State");

                entity.Property(e => e.FormInfoPartSyncState).HasColumnName("FormInfoPart_SyncState");

                entity.Property(e => e.FormInfoPartTableNo).HasColumnName("FormInfoPart_TableNo");

                entity.Property(e => e.FormInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("FormInfoPart_VarParamA");

                entity.Property(e => e.FormInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("FormInfoPart_VarParamB");
            });

            modelBuilder.Entity<TappIteminfopart1>(entity =>
            {
                entity.HasKey(e => e.ItemInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_iteminfopart1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ItemInfoPartTableNo, "Index");

                entity.Property(e => e.ItemInfoPartId).HasColumnName("ItemInfoPart_ID");

                entity.Property(e => e.ItemInfoPartAmount).HasColumnName("ItemInfoPart_Amount");

                entity.Property(e => e.ItemInfoPartAttributeValueCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartCartCode).HasColumnName("ItemInfoPart_CartCode");

                entity.Property(e => e.ItemInfoPartChangeAmount).HasColumnName("ItemInfoPart_ChangeAmount");

                entity.Property(e => e.ItemInfoPartChangeQty).HasColumnName("ItemInfoPart_ChangeQTY");

                entity.Property(e => e.ItemInfoPartCompanyCode).HasColumnName("ItemInfoPart_CompanyCode");

                entity.Property(e => e.ItemInfoPartCost).HasColumnName("ItemInfoPart_Cost");

                entity.Property(e => e.ItemInfoPartDealState).HasColumnName("ItemInfoPart_DealState");

                entity.Property(e => e.ItemInfoPartEcstoreCode).HasColumnName("ItemInfoPart_ECStoreCode");

                entity.Property(e => e.ItemInfoPartFloatParamA).HasColumnName("ItemInfoPart_FloatParamA");

                entity.Property(e => e.ItemInfoPartFloatParamB).HasColumnName("ItemInfoPart_FloatParamB");

                entity.Property(e => e.ItemInfoPartIntParamA).HasColumnName("ItemInfoPart_IntParamA");

                entity.Property(e => e.ItemInfoPartIntParamB).HasColumnName("ItemInfoPart_IntParamB");

                entity.Property(e => e.ItemInfoPartItemCode).HasColumnName("ItemInfoPart_ItemCode");

                entity.Property(e => e.ItemInfoPartItemId).HasColumnName("ItemInfoPart_ItemID");

                entity.Property(e => e.ItemInfoPartItemMsg)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_ItemMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartNoTax).HasColumnName("ItemInfoPart_NoTax");

                entity.Property(e => e.ItemInfoPartOtherCode).HasColumnName("ItemInfoPart_OtherCode");

                entity.Property(e => e.ItemInfoPartParamQty).HasColumnName("ItemInfoPart_ParamQTY");

                entity.Property(e => e.ItemInfoPartPayAmount).HasColumnName("ItemInfoPart_PayAmount");

                entity.Property(e => e.ItemInfoPartQuantity).HasColumnName("ItemInfoPart_Quantity");

                entity.Property(e => e.ItemInfoPartReceiptPrice).HasColumnName("ItemInfoPart_ReceiptPrice");

                entity.Property(e => e.ItemInfoPartReceiptText)
                    .HasMaxLength(10)
                    .HasColumnName("ItemInfoPart_ReceiptText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartShareQty).HasColumnName("ItemInfoPart_ShareQTY");

                entity.Property(e => e.ItemInfoPartState).HasColumnName("ItemInfoPart_State");

                entity.Property(e => e.ItemInfoPartSupplierCode).HasColumnName("ItemInfoPart_SupplierCode");

                entity.Property(e => e.ItemInfoPartSyncState).HasColumnName("ItemInfoPart_SyncState");

                entity.Property(e => e.ItemInfoPartTableNo).HasColumnName("ItemInfoPart_TableNo");

                entity.Property(e => e.ItemInfoPartTax).HasColumnName("ItemInfoPart_Tax");

                entity.Property(e => e.ItemInfoPartTrueAmount).HasColumnName("ItemInfoPart_TrueAmount");

                entity.Property(e => e.ItemInfoPartType).HasColumnName("ItemInfoPart_Type");

                entity.Property(e => e.ItemInfoPartUpTableNo).HasColumnName("ItemInfoPart_UpTableNo");

                entity.Property(e => e.ItemInfoPartUserDefineCode).HasColumnName("ItemInfoPart_UserDefineCode");

                entity.Property(e => e.ItemInfoPartUserDefineName)
                    .HasMaxLength(64)
                    .HasColumnName("ItemInfoPart_UserDefineName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ItemInfoPart_VarParamA");

                entity.Property(e => e.ItemInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ItemInfoPart_VarParamB");

                entity.Property(e => e.ItemInfoPartVoucherCode)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_VoucherCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TappIteminfopart2>(entity =>
            {
                entity.HasKey(e => e.ItemInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_iteminfopart2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ItemInfoPartTableNo, "Index");

                entity.Property(e => e.ItemInfoPartId).HasColumnName("ItemInfoPart_ID");

                entity.Property(e => e.ItemInfoPartAmount).HasColumnName("ItemInfoPart_Amount");

                entity.Property(e => e.ItemInfoPartAttributeValueCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartCartCode).HasColumnName("ItemInfoPart_CartCode");

                entity.Property(e => e.ItemInfoPartChangeAmount).HasColumnName("ItemInfoPart_ChangeAmount");

                entity.Property(e => e.ItemInfoPartChangeQty).HasColumnName("ItemInfoPart_ChangeQTY");

                entity.Property(e => e.ItemInfoPartCompanyCode).HasColumnName("ItemInfoPart_CompanyCode");

                entity.Property(e => e.ItemInfoPartCost).HasColumnName("ItemInfoPart_Cost");

                entity.Property(e => e.ItemInfoPartDealState).HasColumnName("ItemInfoPart_DealState");

                entity.Property(e => e.ItemInfoPartEcstoreCode).HasColumnName("ItemInfoPart_ECStoreCode");

                entity.Property(e => e.ItemInfoPartFloatParamA).HasColumnName("ItemInfoPart_FloatParamA");

                entity.Property(e => e.ItemInfoPartFloatParamB).HasColumnName("ItemInfoPart_FloatParamB");

                entity.Property(e => e.ItemInfoPartIntParamA).HasColumnName("ItemInfoPart_IntParamA");

                entity.Property(e => e.ItemInfoPartIntParamB).HasColumnName("ItemInfoPart_IntParamB");

                entity.Property(e => e.ItemInfoPartItemCode).HasColumnName("ItemInfoPart_ItemCode");

                entity.Property(e => e.ItemInfoPartItemId).HasColumnName("ItemInfoPart_ItemID");

                entity.Property(e => e.ItemInfoPartItemMsg)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_ItemMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartNoTax).HasColumnName("ItemInfoPart_NoTax");

                entity.Property(e => e.ItemInfoPartOtherCode).HasColumnName("ItemInfoPart_OtherCode");

                entity.Property(e => e.ItemInfoPartParamQty).HasColumnName("ItemInfoPart_ParamQTY");

                entity.Property(e => e.ItemInfoPartPayAmount).HasColumnName("ItemInfoPart_PayAmount");

                entity.Property(e => e.ItemInfoPartQuantity).HasColumnName("ItemInfoPart_Quantity");

                entity.Property(e => e.ItemInfoPartReceiptPrice).HasColumnName("ItemInfoPart_ReceiptPrice");

                entity.Property(e => e.ItemInfoPartReceiptText)
                    .HasMaxLength(10)
                    .HasColumnName("ItemInfoPart_ReceiptText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartShareQty).HasColumnName("ItemInfoPart_ShareQTY");

                entity.Property(e => e.ItemInfoPartState).HasColumnName("ItemInfoPart_State");

                entity.Property(e => e.ItemInfoPartSupplierCode).HasColumnName("ItemInfoPart_SupplierCode");

                entity.Property(e => e.ItemInfoPartSyncState).HasColumnName("ItemInfoPart_SyncState");

                entity.Property(e => e.ItemInfoPartTableNo).HasColumnName("ItemInfoPart_TableNo");

                entity.Property(e => e.ItemInfoPartTax).HasColumnName("ItemInfoPart_Tax");

                entity.Property(e => e.ItemInfoPartTrueAmount).HasColumnName("ItemInfoPart_TrueAmount");

                entity.Property(e => e.ItemInfoPartType).HasColumnName("ItemInfoPart_Type");

                entity.Property(e => e.ItemInfoPartUpTableNo).HasColumnName("ItemInfoPart_UpTableNo");

                entity.Property(e => e.ItemInfoPartUserDefineCode).HasColumnName("ItemInfoPart_UserDefineCode");

                entity.Property(e => e.ItemInfoPartUserDefineName)
                    .HasMaxLength(64)
                    .HasColumnName("ItemInfoPart_UserDefineName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ItemInfoPart_VarParamA");

                entity.Property(e => e.ItemInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ItemInfoPart_VarParamB");

                entity.Property(e => e.ItemInfoPartVoucherCode)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_VoucherCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TappIteminfopart3>(entity =>
            {
                entity.HasKey(e => e.ItemInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_iteminfopart3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ItemInfoPartTableNo, "Index");

                entity.Property(e => e.ItemInfoPartId).HasColumnName("ItemInfoPart_ID");

                entity.Property(e => e.ItemInfoPartAmount).HasColumnName("ItemInfoPart_Amount");

                entity.Property(e => e.ItemInfoPartAttributeValueCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartCartCode).HasColumnName("ItemInfoPart_CartCode");

                entity.Property(e => e.ItemInfoPartChangeAmount).HasColumnName("ItemInfoPart_ChangeAmount");

                entity.Property(e => e.ItemInfoPartChangeQty).HasColumnName("ItemInfoPart_ChangeQTY");

                entity.Property(e => e.ItemInfoPartCompanyCode).HasColumnName("ItemInfoPart_CompanyCode");

                entity.Property(e => e.ItemInfoPartCost).HasColumnName("ItemInfoPart_Cost");

                entity.Property(e => e.ItemInfoPartDealState).HasColumnName("ItemInfoPart_DealState");

                entity.Property(e => e.ItemInfoPartEcstoreCode).HasColumnName("ItemInfoPart_ECStoreCode");

                entity.Property(e => e.ItemInfoPartFloatParamA).HasColumnName("ItemInfoPart_FloatParamA");

                entity.Property(e => e.ItemInfoPartFloatParamB).HasColumnName("ItemInfoPart_FloatParamB");

                entity.Property(e => e.ItemInfoPartIntParamA).HasColumnName("ItemInfoPart_IntParamA");

                entity.Property(e => e.ItemInfoPartIntParamB).HasColumnName("ItemInfoPart_IntParamB");

                entity.Property(e => e.ItemInfoPartItemCode).HasColumnName("ItemInfoPart_ItemCode");

                entity.Property(e => e.ItemInfoPartItemId).HasColumnName("ItemInfoPart_ItemID");

                entity.Property(e => e.ItemInfoPartItemMsg)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_ItemMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartNoTax).HasColumnName("ItemInfoPart_NoTax");

                entity.Property(e => e.ItemInfoPartOtherCode).HasColumnName("ItemInfoPart_OtherCode");

                entity.Property(e => e.ItemInfoPartParamQty).HasColumnName("ItemInfoPart_ParamQTY");

                entity.Property(e => e.ItemInfoPartPayAmount).HasColumnName("ItemInfoPart_PayAmount");

                entity.Property(e => e.ItemInfoPartQuantity).HasColumnName("ItemInfoPart_Quantity");

                entity.Property(e => e.ItemInfoPartReceiptPrice).HasColumnName("ItemInfoPart_ReceiptPrice");

                entity.Property(e => e.ItemInfoPartReceiptText)
                    .HasMaxLength(10)
                    .HasColumnName("ItemInfoPart_ReceiptText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartShareQty).HasColumnName("ItemInfoPart_ShareQTY");

                entity.Property(e => e.ItemInfoPartState).HasColumnName("ItemInfoPart_State");

                entity.Property(e => e.ItemInfoPartSupplierCode).HasColumnName("ItemInfoPart_SupplierCode");

                entity.Property(e => e.ItemInfoPartSyncState).HasColumnName("ItemInfoPart_SyncState");

                entity.Property(e => e.ItemInfoPartTableNo).HasColumnName("ItemInfoPart_TableNo");

                entity.Property(e => e.ItemInfoPartTax).HasColumnName("ItemInfoPart_Tax");

                entity.Property(e => e.ItemInfoPartTrueAmount).HasColumnName("ItemInfoPart_TrueAmount");

                entity.Property(e => e.ItemInfoPartType).HasColumnName("ItemInfoPart_Type");

                entity.Property(e => e.ItemInfoPartUpTableNo).HasColumnName("ItemInfoPart_UpTableNo");

                entity.Property(e => e.ItemInfoPartUserDefineCode).HasColumnName("ItemInfoPart_UserDefineCode");

                entity.Property(e => e.ItemInfoPartUserDefineName)
                    .HasMaxLength(64)
                    .HasColumnName("ItemInfoPart_UserDefineName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ItemInfoPart_VarParamA");

                entity.Property(e => e.ItemInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ItemInfoPart_VarParamB");

                entity.Property(e => e.ItemInfoPartVoucherCode)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_VoucherCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TappJoblist>(entity =>
            {
                entity.HasKey(e => e.JobListId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_joblist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.JobListTableInfoNo, e.JobListDealerCode, e.JobListCompanyCode }, "Index");

                entity.Property(e => e.JobListId).HasColumnName("JobList_ID");

                entity.Property(e => e.JobListCompanyCode).HasColumnName("JobList_CompanyCode");

                entity.Property(e => e.JobListDealStateCode).HasColumnName("JobList_DealStateCode");

                entity.Property(e => e.JobListDealStateName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("JobList_DealStateName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JobListDealTypeCode).HasColumnName("JobList_DealTypeCode");

                entity.Property(e => e.JobListDealTypeName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("JobList_DealTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JobListDealerCode).HasColumnName("JobList_DealerCode");

                entity.Property(e => e.JobListDealerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("JobList_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JobListFloatParamA).HasColumnName("JobList_FloatParamA");

                entity.Property(e => e.JobListFloatParamB).HasColumnName("JobList_FloatParamB");

                entity.Property(e => e.JobListHistoryTabCode).HasColumnName("JobList_HistoryTabCode");

                entity.Property(e => e.JobListIntParamA).HasColumnName("JobList_IntParamA");

                entity.Property(e => e.JobListIntParamB).HasColumnName("JobList_IntParamB");

                entity.Property(e => e.JobListLastDealerDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JobList_LastDealerDate");

                entity.Property(e => e.JobListMemo)
                    .HasColumnType("text")
                    .HasColumnName("JobList_Memo");

                entity.Property(e => e.JobListRecorderCode).HasColumnName("JobList_RecorderCode");

                entity.Property(e => e.JobListState).HasColumnName("JobList_State");

                entity.Property(e => e.JobListSyncState).HasColumnName("JobList_SyncState");

                entity.Property(e => e.JobListTableInfoNo).HasColumnName("JobList_TableInfoNo");

                entity.Property(e => e.JobListTableTypeCode).HasColumnName("JobList_TableTypeCode");

                entity.Property(e => e.JobListTableTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("JobList_TableTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JobListUpDealTypeName)
                    .HasMaxLength(64)
                    .HasColumnName("JobList_UpDealTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JobListUpDealerName)
                    .HasMaxLength(50)
                    .HasColumnName("JobList_UpDealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JobListUpTableInfoNo).HasColumnName("JobList_UpTableInfoNo");

                entity.Property(e => e.JobListUrl)
                    .HasColumnType("text")
                    .HasColumnName("JobList_URL");

                entity.Property(e => e.JobListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("JobList_VarParamA");

                entity.Property(e => e.JobListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("JobList_VarParamB");
            });

            modelBuilder.Entity<TappPayinfopart1>(entity =>
            {
                entity.HasKey(e => e.PayInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_payinfopart1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.PayInfoPartPayOrderTableNo, e.PayInfoPartTableNo }, "Index");

                entity.Property(e => e.PayInfoPartId).HasColumnName("PayInfoPart_ID");

                entity.Property(e => e.PayInfoPartAlterAmount).HasColumnName("PayInfoPart_AlterAmount");

                entity.Property(e => e.PayInfoPartAmount).HasColumnName("PayInfoPart_Amount");

                entity.Property(e => e.PayInfoPartCalculateType).HasColumnName("PayInfoPart_CalculateType");

                entity.Property(e => e.PayInfoPartCamount).HasColumnName("PayInfoPart_CAmount");

                entity.Property(e => e.PayInfoPartFeeType).HasColumnName("PayInfoPart_FeeType");

                entity.Property(e => e.PayInfoPartFloatParamA).HasColumnName("PayInfoPart_FloatParamA");

                entity.Property(e => e.PayInfoPartFloatParamB).HasColumnName("PayInfoPart_FloatParamB");

                entity.Property(e => e.PayInfoPartFloatParamC).HasColumnName("PayInfoPart_FloatParamC");

                entity.Property(e => e.PayInfoPartInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayInfoPart_InsertDate");

                entity.Property(e => e.PayInfoPartIntParamA).HasColumnName("PayInfoPart_IntParamA");

                entity.Property(e => e.PayInfoPartIntParamB).HasColumnName("PayInfoPart_IntParamB");

                entity.Property(e => e.PayInfoPartIntParamC).HasColumnName("PayInfoPart_IntParamC");

                entity.Property(e => e.PayInfoPartIsReport).HasColumnName("PayInfoPart_IsReport");

                entity.Property(e => e.PayInfoPartItemNo).HasColumnName("PayInfoPart_ItemNo");

                entity.Property(e => e.PayInfoPartMaxAmount).HasColumnName("PayInfoPart_MaxAmount");

                entity.Property(e => e.PayInfoPartMinAmount).HasColumnName("PayInfoPart_MinAmount");

                entity.Property(e => e.PayInfoPartNoTax).HasColumnName("PayInfoPart_NoTax");

                entity.Property(e => e.PayInfoPartPayItemCode).HasColumnName("PayInfoPart_PayItemCode");

                entity.Property(e => e.PayInfoPartPayItemExtName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PayInfoPart_PayItemExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayInfoPartPayItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PayInfoPart_PayItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayInfoPartPayOrderTableNo).HasColumnName("PayInfoPart_PayOrderTableNo");

                entity.Property(e => e.PayInfoPartPayToCurrency).HasColumnName("PayInfoPart_PayToCurrency");

                entity.Property(e => e.PayInfoPartPayType).HasColumnName("PayInfoPart_PayType");

                entity.Property(e => e.PayInfoPartPaymentState).HasColumnName("PayInfoPart_PaymentState");

                entity.Property(e => e.PayInfoPartShareAmount).HasColumnName("PayInfoPart_ShareAmount");

                entity.Property(e => e.PayInfoPartSpareAmount).HasColumnName("PayInfoPart_SpareAmount");

                entity.Property(e => e.PayInfoPartState).HasColumnName("PayInfoPart_State");

                entity.Property(e => e.PayInfoPartTableNo).HasColumnName("PayInfoPart_TableNo");

                entity.Property(e => e.PayInfoPartTargetCode).HasColumnName("PayInfoPart_TargetCode");

                entity.Property(e => e.PayInfoPartTax).HasColumnName("PayInfoPart_Tax");

                entity.Property(e => e.PayInfoPartUpItemNo).HasColumnName("PayInfoPart_UpItemNo");

                entity.Property(e => e.PayInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamA");

                entity.Property(e => e.PayInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamB");

                entity.Property(e => e.PayInfoPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamC");
            });

            modelBuilder.Entity<TappPayinfopart2>(entity =>
            {
                entity.HasKey(e => e.PayInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_payinfopart2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.PayInfoPartPayOrderTableNo, e.PayInfoPartTableNo }, "Index");

                entity.Property(e => e.PayInfoPartId).HasColumnName("PayInfoPart_ID");

                entity.Property(e => e.PayInfoPartAlterAmount).HasColumnName("PayInfoPart_AlterAmount");

                entity.Property(e => e.PayInfoPartAmount).HasColumnName("PayInfoPart_Amount");

                entity.Property(e => e.PayInfoPartCalculateType).HasColumnName("PayInfoPart_CalculateType");

                entity.Property(e => e.PayInfoPartCamount).HasColumnName("PayInfoPart_CAmount");

                entity.Property(e => e.PayInfoPartFeeType).HasColumnName("PayInfoPart_FeeType");

                entity.Property(e => e.PayInfoPartFloatParamA).HasColumnName("PayInfoPart_FloatParamA");

                entity.Property(e => e.PayInfoPartFloatParamB).HasColumnName("PayInfoPart_FloatParamB");

                entity.Property(e => e.PayInfoPartFloatParamC).HasColumnName("PayInfoPart_FloatParamC");

                entity.Property(e => e.PayInfoPartInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayInfoPart_InsertDate");

                entity.Property(e => e.PayInfoPartIntParamA).HasColumnName("PayInfoPart_IntParamA");

                entity.Property(e => e.PayInfoPartIntParamB).HasColumnName("PayInfoPart_IntParamB");

                entity.Property(e => e.PayInfoPartIntParamC).HasColumnName("PayInfoPart_IntParamC");

                entity.Property(e => e.PayInfoPartIsReport).HasColumnName("PayInfoPart_IsReport");

                entity.Property(e => e.PayInfoPartItemNo).HasColumnName("PayInfoPart_ItemNo");

                entity.Property(e => e.PayInfoPartMaxAmount).HasColumnName("PayInfoPart_MaxAmount");

                entity.Property(e => e.PayInfoPartMinAmount).HasColumnName("PayInfoPart_MinAmount");

                entity.Property(e => e.PayInfoPartNoTax).HasColumnName("PayInfoPart_NoTax");

                entity.Property(e => e.PayInfoPartPayItemCode).HasColumnName("PayInfoPart_PayItemCode");

                entity.Property(e => e.PayInfoPartPayItemExtName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PayInfoPart_PayItemExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayInfoPartPayItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PayInfoPart_PayItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayInfoPartPayOrderTableNo).HasColumnName("PayInfoPart_PayOrderTableNo");

                entity.Property(e => e.PayInfoPartPayToCurrency).HasColumnName("PayInfoPart_PayToCurrency");

                entity.Property(e => e.PayInfoPartPayType).HasColumnName("PayInfoPart_PayType");

                entity.Property(e => e.PayInfoPartPaymentState).HasColumnName("PayInfoPart_PaymentState");

                entity.Property(e => e.PayInfoPartShareAmount).HasColumnName("PayInfoPart_ShareAmount");

                entity.Property(e => e.PayInfoPartSpareAmount).HasColumnName("PayInfoPart_SpareAmount");

                entity.Property(e => e.PayInfoPartState).HasColumnName("PayInfoPart_State");

                entity.Property(e => e.PayInfoPartTableNo).HasColumnName("PayInfoPart_TableNo");

                entity.Property(e => e.PayInfoPartTargetCode).HasColumnName("PayInfoPart_TargetCode");

                entity.Property(e => e.PayInfoPartTax).HasColumnName("PayInfoPart_Tax");

                entity.Property(e => e.PayInfoPartUpItemNo).HasColumnName("PayInfoPart_UpItemNo");

                entity.Property(e => e.PayInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamA");

                entity.Property(e => e.PayInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamB");

                entity.Property(e => e.PayInfoPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamC");
            });

            modelBuilder.Entity<TappPayinfopart3>(entity =>
            {
                entity.HasKey(e => e.PayInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_payinfopart3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.PayInfoPartPayOrderTableNo, e.PayInfoPartTableNo }, "Index");

                entity.Property(e => e.PayInfoPartId).HasColumnName("PayInfoPart_ID");

                entity.Property(e => e.PayInfoPartAlterAmount).HasColumnName("PayInfoPart_AlterAmount");

                entity.Property(e => e.PayInfoPartAmount).HasColumnName("PayInfoPart_Amount");

                entity.Property(e => e.PayInfoPartCalculateType).HasColumnName("PayInfoPart_CalculateType");

                entity.Property(e => e.PayInfoPartCamount).HasColumnName("PayInfoPart_CAmount");

                entity.Property(e => e.PayInfoPartFeeType).HasColumnName("PayInfoPart_FeeType");

                entity.Property(e => e.PayInfoPartFloatParamA).HasColumnName("PayInfoPart_FloatParamA");

                entity.Property(e => e.PayInfoPartFloatParamB).HasColumnName("PayInfoPart_FloatParamB");

                entity.Property(e => e.PayInfoPartFloatParamC).HasColumnName("PayInfoPart_FloatParamC");

                entity.Property(e => e.PayInfoPartInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayInfoPart_InsertDate");

                entity.Property(e => e.PayInfoPartIntParamA).HasColumnName("PayInfoPart_IntParamA");

                entity.Property(e => e.PayInfoPartIntParamB).HasColumnName("PayInfoPart_IntParamB");

                entity.Property(e => e.PayInfoPartIntParamC).HasColumnName("PayInfoPart_IntParamC");

                entity.Property(e => e.PayInfoPartIsReport).HasColumnName("PayInfoPart_IsReport");

                entity.Property(e => e.PayInfoPartItemNo).HasColumnName("PayInfoPart_ItemNo");

                entity.Property(e => e.PayInfoPartMaxAmount).HasColumnName("PayInfoPart_MaxAmount");

                entity.Property(e => e.PayInfoPartMinAmount).HasColumnName("PayInfoPart_MinAmount");

                entity.Property(e => e.PayInfoPartNoTax).HasColumnName("PayInfoPart_NoTax");

                entity.Property(e => e.PayInfoPartPayItemCode).HasColumnName("PayInfoPart_PayItemCode");

                entity.Property(e => e.PayInfoPartPayItemExtName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PayInfoPart_PayItemExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayInfoPartPayItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PayInfoPart_PayItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayInfoPartPayOrderTableNo).HasColumnName("PayInfoPart_PayOrderTableNo");

                entity.Property(e => e.PayInfoPartPayToCurrency).HasColumnName("PayInfoPart_PayToCurrency");

                entity.Property(e => e.PayInfoPartPayType).HasColumnName("PayInfoPart_PayType");

                entity.Property(e => e.PayInfoPartPaymentState).HasColumnName("PayInfoPart_PaymentState");

                entity.Property(e => e.PayInfoPartShareAmount).HasColumnName("PayInfoPart_ShareAmount");

                entity.Property(e => e.PayInfoPartSpareAmount).HasColumnName("PayInfoPart_SpareAmount");

                entity.Property(e => e.PayInfoPartState).HasColumnName("PayInfoPart_State");

                entity.Property(e => e.PayInfoPartTableNo).HasColumnName("PayInfoPart_TableNo");

                entity.Property(e => e.PayInfoPartTargetCode).HasColumnName("PayInfoPart_TargetCode");

                entity.Property(e => e.PayInfoPartTax).HasColumnName("PayInfoPart_Tax");

                entity.Property(e => e.PayInfoPartUpItemNo).HasColumnName("PayInfoPart_UpItemNo");

                entity.Property(e => e.PayInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamA");

                entity.Property(e => e.PayInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamB");

                entity.Property(e => e.PayInfoPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("PayInfoPart_VarParamC");
            });

            modelBuilder.Entity<TappReftable>(entity =>
            {
                entity.HasKey(e => e.RefTableId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_reftable");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.RefTableTableTypeCode, e.RefTableMapTableTypeCode }, "Index");

                entity.Property(e => e.RefTableId).HasColumnName("RefTable_ID");

                entity.Property(e => e.RefTableActuallyPaidState)
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_ActuallyPaidState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RefTable_Date");

                entity.Property(e => e.RefTableDeliveryState)
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_DeliveryState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTableFloatParamA).HasColumnName("RefTable_FloatParamA");

                entity.Property(e => e.RefTableFloatParamB).HasColumnName("RefTable_FloatParamB");

                entity.Property(e => e.RefTableIntParamA).HasColumnName("RefTable_IntParamA");

                entity.Property(e => e.RefTableIntParamB).HasColumnName("RefTable_IntParamB");

                entity.Property(e => e.RefTableIsLock)
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_IsLock")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTableMapTableTypeCode).HasColumnName("RefTable_MapTableTypeCode");

                entity.Property(e => e.RefTableMapTableTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_MapTableTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTablePaymentState)
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_PaymentState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTableRevenueState)
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_RevenueState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTableShippingState)
                    .HasMaxLength(100)
                    .HasColumnName("RefTable_ShippingState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefTableSql)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("RefTable_SQL");

                entity.Property(e => e.RefTableState).HasColumnName("RefTable_State");

                entity.Property(e => e.RefTableSyncState).HasColumnName("RefTable_SyncState");

                entity.Property(e => e.RefTableTableTypeCode).HasColumnName("RefTable_TableTypeCode");

                entity.Property(e => e.RefTableVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("RefTable_VarParamA");

                entity.Property(e => e.RefTableVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("RefTable_VarParamB");
            });

            modelBuilder.Entity<TappReftablepart>(entity =>
            {
                entity.HasKey(e => e.RefTablePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_reftablepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.RefTablePartRefTableId, "Index");

                entity.Property(e => e.RefTablePartId).HasColumnName("RefTablePart_ID");

                entity.Property(e => e.RefTablePartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RefTablePart_Date");

                entity.Property(e => e.RefTablePartDealTypeCode).HasColumnName("RefTablePart_DealTypeCode");

                entity.Property(e => e.RefTablePartFloatParamA).HasColumnName("RefTablePart_FloatParamA");

                entity.Property(e => e.RefTablePartFloatParamB).HasColumnName("RefTablePart_FloatParamB");

                entity.Property(e => e.RefTablePartIntParamA).HasColumnName("RefTablePart_IntParamA");

                entity.Property(e => e.RefTablePartIntParamB).HasColumnName("RefTablePart_IntParamB");

                entity.Property(e => e.RefTablePartMapDealStateCode).HasColumnName("RefTablePart_MapDealStateCode");

                entity.Property(e => e.RefTablePartMapDealTypeCode).HasColumnName("RefTablePart_MapDealTypeCode");

                entity.Property(e => e.RefTablePartRefTableId).HasColumnName("RefTablePart_RefTableID");

                entity.Property(e => e.RefTablePartState).HasColumnName("RefTablePart_State");

                entity.Property(e => e.RefTablePartSyncState).HasColumnName("RefTablePart_SyncState");

                entity.Property(e => e.RefTablePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("RefTablePart_VarParamA");

                entity.Property(e => e.RefTablePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("RefTablePart_VarParamB");
            });

            modelBuilder.Entity<TappServiceinfo>(entity =>
            {
                entity.HasKey(e => e.ServiceInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_serviceinfo");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ServiceInfoCode, e.ServiceInfoApcode }, "Index");

                entity.Property(e => e.ServiceInfoId).HasColumnName("ServiceInfo_ID");

                entity.Property(e => e.ServiceInfoApcode).HasColumnName("ServiceInfo_APCode");

                entity.Property(e => e.ServiceInfoClockToRun)
                    .HasMaxLength(100)
                    .HasColumnName("ServiceInfo_ClockToRun")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServiceInfoCode).HasColumnName("ServiceInfo_Code");

                entity.Property(e => e.ServiceInfoDateToRun)
                    .HasMaxLength(20)
                    .HasColumnName("ServiceInfo_DateToRun")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServiceInfoFloatParamA).HasColumnName("ServiceInfo_FloatParamA");

                entity.Property(e => e.ServiceInfoFloatParamB).HasColumnName("ServiceInfo_FloatParamB");

                entity.Property(e => e.ServiceInfoIntParamA).HasColumnName("ServiceInfo_IntParamA");

                entity.Property(e => e.ServiceInfoIntParamB).HasColumnName("ServiceInfo_IntParamB");

                entity.Property(e => e.ServiceInfoName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ServiceInfo_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServiceInfoRunMode).HasColumnName("ServiceInfo_RunMode");

                entity.Property(e => e.ServiceInfoState).HasColumnName("ServiceInfo_State");

                entity.Property(e => e.ServiceInfoSyncState).HasColumnName("ServiceInfo_SyncState");

                entity.Property(e => e.ServiceInfoTimeUpRun).HasColumnName("ServiceInfo_TimeUpRun");

                entity.Property(e => e.ServiceInfoUimode).HasColumnName("ServiceInfo_UIMode");

                entity.Property(e => e.ServiceInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ServiceInfo_VarParamA");

                entity.Property(e => e.ServiceInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ServiceInfo_VarParamB");
            });

            modelBuilder.Entity<TappServicesjoblist>(entity =>
            {
                entity.HasKey(e => e.ServicesJobListId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_servicesjoblist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ServicesJobListServiceInfoCode, "Index");

                entity.Property(e => e.ServicesJobListId).HasColumnName("ServicesJobList_ID");

                entity.Property(e => e.ServicesJobListDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ServicesJobList_Date");

                entity.Property(e => e.ServicesJobListDealerName)
                    .HasMaxLength(100)
                    .HasColumnName("ServicesJobList_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServicesJobListEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ServicesJobList_EndDate");

                entity.Property(e => e.ServicesJobListFloatParamA).HasColumnName("ServicesJobList_FloatParamA");

                entity.Property(e => e.ServicesJobListFloatParamB).HasColumnName("ServicesJobList_FloatParamB");

                entity.Property(e => e.ServicesJobListIntParamA).HasColumnName("ServicesJobList_IntParamA");

                entity.Property(e => e.ServicesJobListIntParamB).HasColumnName("ServicesJobList_IntParamB");

                entity.Property(e => e.ServicesJobListJobState).HasColumnName("ServicesJobList_JobState");

                entity.Property(e => e.ServicesJobListLogUrl)
                    .HasColumnType("text")
                    .HasColumnName("ServicesJobList_LogURL");

                entity.Property(e => e.ServicesJobListMessage)
                    .HasColumnType("text")
                    .HasColumnName("ServicesJobList_Message");

                entity.Property(e => e.ServicesJobListResult).HasColumnName("ServicesJobList_Result");

                entity.Property(e => e.ServicesJobListRunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ServicesJobList_RunDate");

                entity.Property(e => e.ServicesJobListServiceInfoCode).HasColumnName("ServicesJobList_ServiceInfoCode");

                entity.Property(e => e.ServicesJobListState).HasColumnName("ServicesJobList_State");

                entity.Property(e => e.ServicesJobListSyncState).HasColumnName("ServicesJobList_SyncState");

                entity.Property(e => e.ServicesJobListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ServicesJobList_VarParamA");

                entity.Property(e => e.ServicesJobListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ServicesJobList_VarParamB");
            });

            modelBuilder.Entity<TappSumpayinfopart1>(entity =>
            {
                entity.HasKey(e => e.SumPayInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_sumpayinfopart1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.SumPayInfoPartTableNo, e.SumPayInfoPartPayOrderNo, e.SumPayInfoPartReceiverCode }, "Index");

                entity.Property(e => e.SumPayInfoPartId).HasColumnName("SumPayInfoPart_ID");

                entity.Property(e => e.SumPayInfoPartActuallyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_ActuallyDate");

                entity.Property(e => e.SumPayInfoPartActuallyState).HasColumnName("SumPayInfoPart_ActuallyState");

                entity.Property(e => e.SumPayInfoPartAmount).HasColumnName("SumPayInfoPart_Amount");

                entity.Property(e => e.SumPayInfoPartBaseCode).HasColumnName("SumPayInfoPart_BaseCode");

                entity.Property(e => e.SumPayInfoPartChanged).HasColumnName("SumPayInfoPart_Changed");

                entity.Property(e => e.SumPayInfoPartCreditAmount).HasColumnName("SumPayInfoPart_CreditAmount");

                entity.Property(e => e.SumPayInfoPartDealState).HasColumnName("SumPayInfoPart_DealState");

                entity.Property(e => e.SumPayInfoPartFloatParamA).HasColumnName("SumPayInfoPart_FloatParamA");

                entity.Property(e => e.SumPayInfoPartFloatParamB).HasColumnName("SumPayInfoPart_FloatParamB");

                entity.Property(e => e.SumPayInfoPartFloatParamC).HasColumnName("SumPayInfoPart_FloatParamC");

                entity.Property(e => e.SumPayInfoPartFormAmount).HasColumnName("SumPayInfoPart_FormAmount");

                entity.Property(e => e.SumPayInfoPartIntParamA).HasColumnName("SumPayInfoPart_IntParamA");

                entity.Property(e => e.SumPayInfoPartIntParamB).HasColumnName("SumPayInfoPart_IntParamB");

                entity.Property(e => e.SumPayInfoPartIntParamC).HasColumnName("SumPayInfoPart_IntParamC");

                entity.Property(e => e.SumPayInfoPartInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_InvoiceDate");

                entity.Property(e => e.SumPayInfoPartInvoiceState).HasColumnName("SumPayInfoPart_InvoiceState");

                entity.Property(e => e.SumPayInfoPartPayOrderNo).HasColumnName("SumPayInfoPart_PayOrderNo");

                entity.Property(e => e.SumPayInfoPartPayOrderTableNo).HasColumnName("SumPayInfoPart_PayOrderTableNo");

                entity.Property(e => e.SumPayInfoPartPayToCurrency).HasColumnName("SumPayInfoPart_PayToCurrency");

                entity.Property(e => e.SumPayInfoPartPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_PaymentDate");

                entity.Property(e => e.SumPayInfoPartPaymentState).HasColumnName("SumPayInfoPart_PaymentState");

                entity.Property(e => e.SumPayInfoPartReceiverCode).HasColumnName("SumPayInfoPart_ReceiverCode");

                entity.Property(e => e.SumPayInfoPartReceiverName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SumPayInfoPart_ReceiverName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SumPayInfoPartRefundAmount).HasColumnName("SumPayInfoPart_RefundAmount");

                entity.Property(e => e.SumPayInfoPartRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_RefundDate");

                entity.Property(e => e.SumPayInfoPartRefundState).HasColumnName("SumPayInfoPart_RefundState");

                entity.Property(e => e.SumPayInfoPartState).HasColumnName("SumPayInfoPart_State");

                entity.Property(e => e.SumPayInfoPartTableNo).HasColumnName("SumPayInfoPart_TableNo");

                entity.Property(e => e.SumPayInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamA");

                entity.Property(e => e.SumPayInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamB");

                entity.Property(e => e.SumPayInfoPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamC");
            });

            modelBuilder.Entity<TappSumpayinfopart2>(entity =>
            {
                entity.HasKey(e => e.SumPayInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_sumpayinfopart2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.SumPayInfoPartTableNo, e.SumPayInfoPartPayOrderNo, e.SumPayInfoPartReceiverCode }, "Index");

                entity.Property(e => e.SumPayInfoPartId).HasColumnName("SumPayInfoPart_ID");

                entity.Property(e => e.SumPayInfoPartActuallyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_ActuallyDate");

                entity.Property(e => e.SumPayInfoPartActuallyState).HasColumnName("SumPayInfoPart_ActuallyState");

                entity.Property(e => e.SumPayInfoPartAmount).HasColumnName("SumPayInfoPart_Amount");

                entity.Property(e => e.SumPayInfoPartBaseCode).HasColumnName("SumPayInfoPart_BaseCode");

                entity.Property(e => e.SumPayInfoPartChanged).HasColumnName("SumPayInfoPart_Changed");

                entity.Property(e => e.SumPayInfoPartCreditAmount).HasColumnName("SumPayInfoPart_CreditAmount");

                entity.Property(e => e.SumPayInfoPartDealState).HasColumnName("SumPayInfoPart_DealState");

                entity.Property(e => e.SumPayInfoPartFloatParamA).HasColumnName("SumPayInfoPart_FloatParamA");

                entity.Property(e => e.SumPayInfoPartFloatParamB).HasColumnName("SumPayInfoPart_FloatParamB");

                entity.Property(e => e.SumPayInfoPartFloatParamC).HasColumnName("SumPayInfoPart_FloatParamC");

                entity.Property(e => e.SumPayInfoPartFormAmount).HasColumnName("SumPayInfoPart_FormAmount");

                entity.Property(e => e.SumPayInfoPartIntParamA).HasColumnName("SumPayInfoPart_IntParamA");

                entity.Property(e => e.SumPayInfoPartIntParamB).HasColumnName("SumPayInfoPart_IntParamB");

                entity.Property(e => e.SumPayInfoPartIntParamC).HasColumnName("SumPayInfoPart_IntParamC");

                entity.Property(e => e.SumPayInfoPartInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_InvoiceDate");

                entity.Property(e => e.SumPayInfoPartInvoiceState).HasColumnName("SumPayInfoPart_InvoiceState");

                entity.Property(e => e.SumPayInfoPartPayOrderNo).HasColumnName("SumPayInfoPart_PayOrderNo");

                entity.Property(e => e.SumPayInfoPartPayOrderTableNo).HasColumnName("SumPayInfoPart_PayOrderTableNo");

                entity.Property(e => e.SumPayInfoPartPayToCurrency).HasColumnName("SumPayInfoPart_PayToCurrency");

                entity.Property(e => e.SumPayInfoPartPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_PaymentDate");

                entity.Property(e => e.SumPayInfoPartPaymentState).HasColumnName("SumPayInfoPart_PaymentState");

                entity.Property(e => e.SumPayInfoPartReceiverCode).HasColumnName("SumPayInfoPart_ReceiverCode");

                entity.Property(e => e.SumPayInfoPartReceiverName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SumPayInfoPart_ReceiverName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SumPayInfoPartRefundAmount).HasColumnName("SumPayInfoPart_RefundAmount");

                entity.Property(e => e.SumPayInfoPartRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_RefundDate");

                entity.Property(e => e.SumPayInfoPartRefundState).HasColumnName("SumPayInfoPart_RefundState");

                entity.Property(e => e.SumPayInfoPartState).HasColumnName("SumPayInfoPart_State");

                entity.Property(e => e.SumPayInfoPartTableNo).HasColumnName("SumPayInfoPart_TableNo");

                entity.Property(e => e.SumPayInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamA");

                entity.Property(e => e.SumPayInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamB");

                entity.Property(e => e.SumPayInfoPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamC");
            });

            modelBuilder.Entity<TappSumpayinfopart3>(entity =>
            {
                entity.HasKey(e => e.SumPayInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_sumpayinfopart3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.SumPayInfoPartTableNo, e.SumPayInfoPartPayOrderTableNo, e.SumPayInfoPartReceiverCode }, "Index");

                entity.Property(e => e.SumPayInfoPartId).HasColumnName("SumPayInfoPart_ID");

                entity.Property(e => e.SumPayInfoPartActuallyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_ActuallyDate");

                entity.Property(e => e.SumPayInfoPartActuallyState).HasColumnName("SumPayInfoPart_ActuallyState");

                entity.Property(e => e.SumPayInfoPartAmount).HasColumnName("SumPayInfoPart_Amount");

                entity.Property(e => e.SumPayInfoPartBaseCode).HasColumnName("SumPayInfoPart_BaseCode");

                entity.Property(e => e.SumPayInfoPartChanged).HasColumnName("SumPayInfoPart_Changed");

                entity.Property(e => e.SumPayInfoPartCreditAmount).HasColumnName("SumPayInfoPart_CreditAmount");

                entity.Property(e => e.SumPayInfoPartDealState).HasColumnName("SumPayInfoPart_DealState");

                entity.Property(e => e.SumPayInfoPartFloatParamA).HasColumnName("SumPayInfoPart_FloatParamA");

                entity.Property(e => e.SumPayInfoPartFloatParamB).HasColumnName("SumPayInfoPart_FloatParamB");

                entity.Property(e => e.SumPayInfoPartFloatParamC).HasColumnName("SumPayInfoPart_FloatParamC");

                entity.Property(e => e.SumPayInfoPartFormAmount).HasColumnName("SumPayInfoPart_FormAmount");

                entity.Property(e => e.SumPayInfoPartIntParamA).HasColumnName("SumPayInfoPart_IntParamA");

                entity.Property(e => e.SumPayInfoPartIntParamB).HasColumnName("SumPayInfoPart_IntParamB");

                entity.Property(e => e.SumPayInfoPartIntParamC).HasColumnName("SumPayInfoPart_IntParamC");

                entity.Property(e => e.SumPayInfoPartInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_InvoiceDate");

                entity.Property(e => e.SumPayInfoPartInvoiceState).HasColumnName("SumPayInfoPart_InvoiceState");

                entity.Property(e => e.SumPayInfoPartPayOrderTableNo).HasColumnName("SumPayInfoPart_PayOrderTableNo");

                entity.Property(e => e.SumPayInfoPartPayToCurrency).HasColumnName("SumPayInfoPart_PayToCurrency");

                entity.Property(e => e.SumPayInfoPartPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_PaymentDate");

                entity.Property(e => e.SumPayInfoPartPaymentState).HasColumnName("SumPayInfoPart_PaymentState");

                entity.Property(e => e.SumPayInfoPartReceiverCode).HasColumnName("SumPayInfoPart_ReceiverCode");

                entity.Property(e => e.SumPayInfoPartReceiverName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SumPayInfoPart_ReceiverName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SumPayInfoPartRefundAmount).HasColumnName("SumPayInfoPart_RefundAmount");

                entity.Property(e => e.SumPayInfoPartRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SumPayInfoPart_RefundDate");

                entity.Property(e => e.SumPayInfoPartRefundState).HasColumnName("SumPayInfoPart_RefundState");

                entity.Property(e => e.SumPayInfoPartState).HasColumnName("SumPayInfoPart_State");

                entity.Property(e => e.SumPayInfoPartTableNo).HasColumnName("SumPayInfoPart_TableNo");

                entity.Property(e => e.SumPayInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamA");

                entity.Property(e => e.SumPayInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamB");

                entity.Property(e => e.SumPayInfoPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("SumPayInfoPart_VarParamC");
            });

            modelBuilder.Entity<TappSystemlog>(entity =>
            {
                entity.HasKey(e => e.SystemLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_systemlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.SystemLogDate, "SystemLogDate");

                entity.Property(e => e.SystemLogId).HasColumnName("SystemLog_ID");

                entity.Property(e => e.SystemLogActionCode).HasColumnName("SystemLog_ActionCode");

                entity.Property(e => e.SystemLogCompanyCode).HasColumnName("SystemLog_CompanyCode");

                entity.Property(e => e.SystemLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SystemLog_Date");

                entity.Property(e => e.SystemLogDealerName)
                    .HasMaxLength(100)
                    .HasColumnName("SystemLog_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SystemLogErrorCode).HasColumnName("SystemLog_ErrorCode");

                entity.Property(e => e.SystemLogException)
                    .HasColumnType("text")
                    .HasColumnName("SystemLog_Exception");

                entity.Property(e => e.SystemLogFloatParamA).HasColumnName("SystemLog_FloatParamA");

                entity.Property(e => e.SystemLogFloatParamB).HasColumnName("SystemLog_FloatParamB");

                entity.Property(e => e.SystemLogIntParamA).HasColumnName("SystemLog_IntParamA");

                entity.Property(e => e.SystemLogIntParamB).HasColumnName("SystemLog_IntParamB");

                entity.Property(e => e.SystemLogIp)
                    .HasMaxLength(50)
                    .HasColumnName("SystemLog_IP")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SystemLogOnErrorSql)
                    .HasColumnType("text")
                    .HasColumnName("SystemLog_OnErrorSQL");

                entity.Property(e => e.SystemLogOperateCode).HasColumnName("SystemLog_OperateCode");

                entity.Property(e => e.SystemLogOperateName)
                    .HasMaxLength(100)
                    .HasColumnName("SystemLog_OperateName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SystemLogRequestModel)
                    .HasColumnType("text")
                    .HasColumnName("SystemLog_RequestModel");

                entity.Property(e => e.SystemLogResponseModel)
                    .HasColumnType("text")
                    .HasColumnName("SystemLog_ResponseModel");

                entity.Property(e => e.SystemLogServicesVer)
                    .HasMaxLength(100)
                    .HasColumnName("SystemLog_ServicesVer")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SystemLogSyncState).HasColumnName("SystemLog_SyncState");

                entity.Property(e => e.SystemLogType).HasColumnName("SystemLog_Type");

                entity.Property(e => e.SystemLogUserInfoCode).HasColumnName("SystemLog_UserInfoCode");

                entity.Property(e => e.SystemLogVarParamA)
                    .HasMaxLength(50)
                    .HasColumnName("SystemLog_VarParamA")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SystemLogVarParamB)
                    .HasMaxLength(100)
                    .HasColumnName("SystemLog_VarParamB")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TappTableinfo>(entity =>
            {
                entity.HasKey(e => e.TableInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_tableinfo");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.TableInfoTableNo, e.TableInfoMainTableNo }, "Index");

                entity.Property(e => e.TableInfoId).HasColumnName("TableInfo_ID");

                entity.Property(e => e.TableInfoActuallyPaidState).HasColumnName("TableInfo_ActuallyPaidState");

                entity.Property(e => e.TableInfoCompanyCode).HasColumnName("TableInfo_CompanyCode");

                entity.Property(e => e.TableInfoContent)
                    .HasColumnType("text")
                    .HasColumnName("TableInfo_Content");

                entity.Property(e => e.TableInfoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TableInfo_Date");

                entity.Property(e => e.TableInfoDealStateCode).HasColumnName("TableInfo_DealStateCode");

                entity.Property(e => e.TableInfoDealStateName)
                    .HasMaxLength(64)
                    .HasColumnName("TableInfo_DealStateName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoDealStateShowName)
                    .HasMaxLength(64)
                    .HasColumnName("TableInfo_DealStateShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoDealTypeCode).HasColumnName("TableInfo_DealTypeCode");

                entity.Property(e => e.TableInfoDealTypeName)
                    .HasMaxLength(64)
                    .HasColumnName("TableInfo_DealTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoDealerCode).HasColumnName("TableInfo_DealerCode");

                entity.Property(e => e.TableInfoDealerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TableInfo_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoDeliveryState).HasColumnName("TableInfo_DeliveryState");

                entity.Property(e => e.TableInfoFloatParamA).HasColumnName("TableInfo_FloatParamA");

                entity.Property(e => e.TableInfoFloatParamB).HasColumnName("TableInfo_FloatParamB");

                entity.Property(e => e.TableInfoGroupNo).HasColumnName("TableInfo_GroupNo");

                entity.Property(e => e.TableInfoInsertDealerCode).HasColumnName("TableInfo_InsertDealerCode");

                entity.Property(e => e.TableInfoIntParamA).HasColumnName("TableInfo_IntParamA");

                entity.Property(e => e.TableInfoIntParamB).HasColumnName("TableInfo_IntParamB");

                entity.Property(e => e.TableInfoIpaddress)
                    .HasColumnType("text")
                    .HasColumnName("TableInfo_IPAddress");

                entity.Property(e => e.TableInfoLockState).HasColumnName("TableInfo_LockState");

                entity.Property(e => e.TableInfoMainGroupNo).HasColumnName("TableInfo_MainGroupNo");

                entity.Property(e => e.TableInfoMainTableNo).HasColumnName("TableInfo_MainTableNo");

                entity.Property(e => e.TableInfoMemo)
                    .HasColumnType("text")
                    .HasColumnName("TableInfo_Memo");

                entity.Property(e => e.TableInfoModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TableInfo_ModifyDate");

                entity.Property(e => e.TableInfoNextDealTypeCode).HasColumnName("TableInfo_NextDealTypeCode");

                entity.Property(e => e.TableInfoNextDealTypeName)
                    .HasMaxLength(50)
                    .HasColumnName("TableInfo_NextDealTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoPaymentState).HasColumnName("TableInfo_PaymentState");

                entity.Property(e => e.TableInfoRevenueState).HasColumnName("TableInfo_RevenueState");

                entity.Property(e => e.TableInfoShippingState).HasColumnName("TableInfo_ShippingState");

                entity.Property(e => e.TableInfoSyncState).HasColumnName("TableInfo_SyncState");

                entity.Property(e => e.TableInfoTableNo).HasColumnName("TableInfo_TableNo");

                entity.Property(e => e.TableInfoTableTypeCode).HasColumnName("TableInfo_TableTypeCode");

                entity.Property(e => e.TableInfoTableTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TableInfo_TableTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoTableTypeWorkflowId).HasColumnName("TableInfo_TableTypeWorkflowID");

                entity.Property(e => e.TableInfoTemplateState).HasColumnName("TableInfo_TemplateState");

                entity.Property(e => e.TableInfoUpCompanyCode).HasColumnName("TableInfo_UpCompanyCode");

                entity.Property(e => e.TableInfoUpDealerName)
                    .HasMaxLength(50)
                    .HasColumnName("TableInfo_UpDealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoUpGroupNo).HasColumnName("TableInfo_UpGroupNo");

                entity.Property(e => e.TableInfoUpTableInfoModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TableInfo_UpTableInfoModifyDate");

                entity.Property(e => e.TableInfoUpTableInfoNo).HasColumnName("TableInfo_UpTableInfoNo");

                entity.Property(e => e.TableInfoUpTableTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("TableInfo_UpTableTypeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("TableInfo_VarParamA");

                entity.Property(e => e.TableInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("TableInfo_VarParamB");
            });

            modelBuilder.Entity<TappUserlog>(entity =>
            {
                entity.HasKey(e => e.UserLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_userlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.UserLogUserInfoCode, "Index");

                entity.Property(e => e.UserLogId).HasColumnName("UserLog_ID");

                entity.Property(e => e.UserLogFloatParamA).HasColumnName("UserLog_FloatParamA");

                entity.Property(e => e.UserLogFloatParamB).HasColumnName("UserLog_FloatParamB");

                entity.Property(e => e.UserLogIntParamA).HasColumnName("UserLog_IntParamA");

                entity.Property(e => e.UserLogIntParamB).HasColumnName("UserLog_IntParamB");

                entity.Property(e => e.UserLogIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserLog_IP")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserLogLogInTime)
                    .HasColumnType("datetime")
                    .HasColumnName("UserLog_LogInTime");

                entity.Property(e => e.UserLogLogOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("UserLog_LogOutTime");

                entity.Property(e => e.UserLogOnlineState).HasColumnName("UserLog_OnlineState");

                entity.Property(e => e.UserLogSyncState).HasColumnName("UserLog_SyncState");

                entity.Property(e => e.UserLogType).HasColumnName("UserLog_Type");

                entity.Property(e => e.UserLogUserInfoCode).HasColumnName("UserLog_UserInfoCode");

                entity.Property(e => e.UserLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserLog_VarParamA");

                entity.Property(e => e.UserLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserLog_VarParamB");
            });

            modelBuilder.Entity<TappUserloginstate>(entity =>
            {
                entity.HasKey(e => e.UserLoginStateId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_userloginstate");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserLoginStateUserInfoCode, e.UserLoginStateUserDeviceCode, e.UserLoginStateType }, "Index");

                entity.Property(e => e.UserLoginStateId).HasColumnName("UserLoginState_ID");

                entity.Property(e => e.UserLoginStateFloatParamA).HasColumnName("UserLoginState_FloatParamA");

                entity.Property(e => e.UserLoginStateFloatParamB).HasColumnName("UserLoginState_FloatParamB");

                entity.Property(e => e.UserLoginStateIntParamA).HasColumnName("UserLoginState_IntParamA");

                entity.Property(e => e.UserLoginStateIntParamB).HasColumnName("UserLoginState_IntParamB");

                entity.Property(e => e.UserLoginStateIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserLoginState_IP")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserLoginStateLogInTime)
                    .HasColumnType("datetime")
                    .HasColumnName("UserLoginState_LogInTime");

                entity.Property(e => e.UserLoginStateLogOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("UserLoginState_LogOutTime");

                entity.Property(e => e.UserLoginStateOnlineState).HasColumnName("UserLoginState_OnlineState");

                entity.Property(e => e.UserLoginStateSyncState).HasColumnName("UserLoginState_SyncState");

                entity.Property(e => e.UserLoginStateThirdType).HasColumnName("UserLoginState_ThirdType");

                entity.Property(e => e.UserLoginStateType).HasColumnName("UserLoginState_Type");

                entity.Property(e => e.UserLoginStateUserDeviceCode).HasColumnName("UserLoginState_UserDeviceCode");

                entity.Property(e => e.UserLoginStateUserInfoCode).HasColumnName("UserLoginState_UserInfoCode");

                entity.Property(e => e.UserLoginStateVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserLoginState_VarParamA");

                entity.Property(e => e.UserLoginStateVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserLoginState_VarParamB");
            });

            modelBuilder.Entity<TappUseroperatelog>(entity =>
            {
                entity.HasKey(e => e.UserOperateLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_useroperatelog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserOperateLogUserInfoCode, e.UserOperateLogOperateCode }, "Index");

                entity.Property(e => e.UserOperateLogId).HasColumnName("UserOperateLog_ID");

                entity.Property(e => e.UserOperateLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserOperateLog_Date");

                entity.Property(e => e.UserOperateLogFloatParamA).HasColumnName("UserOperateLog_FloatParamA");

                entity.Property(e => e.UserOperateLogFloatParamB).HasColumnName("UserOperateLog_FloatParamB");

                entity.Property(e => e.UserOperateLogIntParamA).HasColumnName("UserOperateLog_IntParamA");

                entity.Property(e => e.UserOperateLogIntParamB).HasColumnName("UserOperateLog_IntParamB");

                entity.Property(e => e.UserOperateLogOperateCode).HasColumnName("UserOperateLog_OperateCode");

                entity.Property(e => e.UserOperateLogSyncState).HasColumnName("UserOperateLog_SyncState");

                entity.Property(e => e.UserOperateLogUserInfoCode).HasColumnName("UserOperateLog_UserInfoCode");

                entity.Property(e => e.UserOperateLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserOperateLog_VarParamA");

                entity.Property(e => e.UserOperateLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserOperateLog_VarParamB");
            });

            modelBuilder.Entity<TappUserreport>(entity =>
            {
                entity.HasKey(e => e.UserReportId)
                    .HasName("PRIMARY");

                entity.ToTable("tapp_userreport");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserReportCategoryCode, e.UserReportItemCode }, "Index");

                entity.Property(e => e.UserReportId).HasColumnName("UserReport_ID");

                entity.Property(e => e.UserReportCategoryCode).HasColumnName("UserReport_CategoryCode");

                entity.Property(e => e.UserReportCategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("UserReport_CategoryName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportCountryCode).HasColumnName("UserReport_CountryCode");

                entity.Property(e => e.UserReportFloatParamA).HasColumnName("UserReport_FloatParamA");

                entity.Property(e => e.UserReportFloatParamB).HasColumnName("UserReport_FloatParamB");

                entity.Property(e => e.UserReportIntParamA).HasColumnName("UserReport_IntParamA");

                entity.Property(e => e.UserReportIntParamB).HasColumnName("UserReport_IntParamB");

                entity.Property(e => e.UserReportIsShow).HasColumnName("UserReport_IsShow");

                entity.Property(e => e.UserReportItemCode).HasColumnName("UserReport_ItemCode");

                entity.Property(e => e.UserReportItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("UserReport_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportMemo)
                    .HasMaxLength(500)
                    .HasColumnName("UserReport_Memo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamA)
                    .HasMaxLength(300)
                    .HasColumnName("UserReport_ParamA")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamB)
                    .HasMaxLength(300)
                    .HasColumnName("UserReport_ParamB")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamC)
                    .HasMaxLength(300)
                    .HasColumnName("UserReport_ParamC")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamD)
                    .HasMaxLength(300)
                    .HasColumnName("UserReport_ParamD")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamE).HasColumnName("UserReport_ParamE");

                entity.Property(e => e.UserReportParamF).HasColumnName("UserReport_ParamF");

                entity.Property(e => e.UserReportParamG).HasColumnName("UserReport_ParamG");

                entity.Property(e => e.UserReportParamH).HasColumnName("UserReport_ParamH");

                entity.Property(e => e.UserReportParamI)
                    .HasMaxLength(300)
                    .HasColumnName("UserReport_ParamI")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamJ)
                    .HasMaxLength(300)
                    .HasColumnName("UserReport_ParamJ")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserReportParamK)
                    .HasColumnType("datetime")
                    .HasColumnName("UserReport_ParamK");

                entity.Property(e => e.UserReportParamL)
                    .HasColumnType("datetime")
                    .HasColumnName("UserReport_ParamL");

                entity.Property(e => e.UserReportSort).HasColumnName("UserReport_Sort");

                entity.Property(e => e.UserReportState).HasColumnName("UserReport_State");

                entity.Property(e => e.UserReportSyncState).HasColumnName("UserReport_SyncState");

                entity.Property(e => e.UserReportUpCategoryCode).HasColumnName("UserReport_UpCategoryCode");

                entity.Property(e => e.UserReportUpItemCode).HasColumnName("UserReport_UpItemCode");

                entity.Property(e => e.UserReportVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserReport_VarParamA");

                entity.Property(e => e.UserReportVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserReport_VarParamB");
            });

            modelBuilder.Entity<TbaseApidatum>(entity =>
            {
                entity.HasKey(e => e.ApidataId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_apidata");

                entity.HasIndex(e => new { e.ApidataPartnerCode, e.ApidataApicode }, "Index");

                entity.Property(e => e.ApidataId).HasColumnName("APIData_ID");

                entity.Property(e => e.ApidataApicode).HasColumnName("APIData_APICode");

                entity.Property(e => e.ApidataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("APIData_Date");

                entity.Property(e => e.ApidataFloatParamA).HasColumnName("APIData_FloatParamA");

                entity.Property(e => e.ApidataFloatParamB).HasColumnName("APIData_FloatParamB");

                entity.Property(e => e.ApidataIntParamA).HasColumnName("APIData_IntParamA");

                entity.Property(e => e.ApidataIntParamB).HasColumnName("APIData_IntParamB");

                entity.Property(e => e.ApidataJsonData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("APIData_JsonData");

                entity.Property(e => e.ApidataPartnerCode).HasColumnName("APIData_PartnerCode");

                entity.Property(e => e.ApidataState).HasColumnName("APIData_State");

                entity.Property(e => e.ApidataStoreId)
                    .HasMaxLength(200)
                    .HasColumnName("APIData_StoreID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApidataSyncState).HasColumnName("APIData_SyncState");

                entity.Property(e => e.ApidataTemplateState).HasColumnName("APIData_TemplateState");

                entity.Property(e => e.ApidataVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("APIData_VarParamA");

                entity.Property(e => e.ApidataVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("APIData_VarParamB");
            });

            modelBuilder.Entity<TbaseAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_attribute");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.AttributeCode, "Index");

                entity.Property(e => e.AttributeId).HasColumnName("Attribute_ID");

                entity.Property(e => e.AttributeCode).HasColumnName("Attribute_Code");

                entity.Property(e => e.AttributeColor)
                    .HasMaxLength(50)
                    .HasColumnName("Attribute_Color")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeEname)
                    .HasMaxLength(50)
                    .HasColumnName("Attribute_EName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeFloatParamA).HasColumnName("Attribute_FloatParamA");

                entity.Property(e => e.AttributeFloatParamB).HasColumnName("Attribute_FloatParamB");

                entity.Property(e => e.AttributeIntParamA).HasColumnName("Attribute_IntParamA");

                entity.Property(e => e.AttributeIntParamB).HasColumnName("Attribute_IntParamB");

                entity.Property(e => e.AttributeMode).HasColumnName("Attribute_Mode");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Attribute_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeSetMode).HasColumnName("Attribute_SetMode");

                entity.Property(e => e.AttributeShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Attribute_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeSort).HasColumnName("Attribute_Sort");

                entity.Property(e => e.AttributeState).HasColumnName("Attribute_State");

                entity.Property(e => e.AttributeSyncState).HasColumnName("Attribute_SyncState");

                entity.Property(e => e.AttributeType).HasColumnName("Attribute_Type");

                entity.Property(e => e.AttributeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Attribute_VarParamA");

                entity.Property(e => e.AttributeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Attribute_VarParamB");
            });

            modelBuilder.Entity<TbaseAttributevalue>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_attributevalue");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.AttributeValueCode, e.AttributeValueAttributeCode }, "Index");

                entity.Property(e => e.AttributeValueId).HasColumnName("AttributeValue_ID");

                entity.Property(e => e.AttributeValueAttributeCode).HasColumnName("AttributeValue_AttributeCode");

                entity.Property(e => e.AttributeValueCode).HasColumnName("AttributeValue_Code");

                entity.Property(e => e.AttributeValueEname)
                    .HasMaxLength(50)
                    .HasColumnName("AttributeValue_EName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeValueFloatParamA).HasColumnName("AttributeValue_FloatParamA");

                entity.Property(e => e.AttributeValueFloatParamB).HasColumnName("AttributeValue_FloatParamB");

                entity.Property(e => e.AttributeValueIntParamA).HasColumnName("AttributeValue_IntParamA");

                entity.Property(e => e.AttributeValueIntParamB).HasColumnName("AttributeValue_IntParamB");

                entity.Property(e => e.AttributeValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AttributeValue_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeValueSetMode).HasColumnName("AttributeValue_SetMode");

                entity.Property(e => e.AttributeValueShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AttributeValue_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AttributeValueSort).HasColumnName("AttributeValue_Sort");

                entity.Property(e => e.AttributeValueState).HasColumnName("AttributeValue_State");

                entity.Property(e => e.AttributeValueSyncState).HasColumnName("AttributeValue_SyncState");

                entity.Property(e => e.AttributeValueVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("AttributeValue_VarParamA");

                entity.Property(e => e.AttributeValueVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("AttributeValue_VarParamB");
            });

            modelBuilder.Entity<TbaseCachedatum>(entity =>
            {
                entity.HasKey(e => e.CacheDataId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_cachedata");

                entity.Property(e => e.CacheDataId).HasColumnName("CacheData_ID");

                entity.Property(e => e.CacheDataBeactionCode).HasColumnName("CacheData_BEActionCode");

                entity.Property(e => e.CacheDataBeoperCode).HasColumnName("CacheData_BEOperCode");

                entity.Property(e => e.CacheDataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CacheData_Date");

                entity.Property(e => e.CacheDataErrMessage)
                    .HasMaxLength(500)
                    .HasColumnName("CacheData_ErrMessage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CacheDataFeactionCode).HasColumnName("CacheData_FEActionCode");

                entity.Property(e => e.CacheDataFloatParamA).HasColumnName("CacheData_FloatParamA");

                entity.Property(e => e.CacheDataFloatParamB).HasColumnName("CacheData_FloatParamB");

                entity.Property(e => e.CacheDataIntParamA).HasColumnName("CacheData_IntParamA");

                entity.Property(e => e.CacheDataIntParamB).HasColumnName("CacheData_IntParamB");

                entity.Property(e => e.CacheDataModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CacheData_ModifyDate");

                entity.Property(e => e.CacheDataState).HasColumnName("CacheData_State");

                entity.Property(e => e.CacheDataSuccess).HasColumnName("CacheData_Success");

                entity.Property(e => e.CacheDataSyncState).HasColumnName("CacheData_SyncState");

                entity.Property(e => e.CacheDataTemplateState).HasColumnName("CacheData_TemplateState");

                entity.Property(e => e.CacheDataVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("CacheData_VarParamA");

                entity.Property(e => e.CacheDataVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("CacheData_VarParamB");
            });

            modelBuilder.Entity<TbaseCachemapping>(entity =>
            {
                entity.HasKey(e => e.CacheMappingId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_cachemapping");

                entity.Property(e => e.CacheMappingId).HasColumnName("CacheMapping_ID");

                entity.Property(e => e.CacheMappingBeactionCode).HasColumnName("CacheMapping_BEActionCode");

                entity.Property(e => e.CacheMappingBeoperCode).HasColumnName("CacheMapping_BEOperCode");

                entity.Property(e => e.CacheMappingFeactionCode).HasColumnName("CacheMapping_FEActionCode");

                entity.Property(e => e.CacheMappingFloatParamA).HasColumnName("CacheMapping_FloatParamA");

                entity.Property(e => e.CacheMappingFloatParamB).HasColumnName("CacheMapping_FloatParamB");

                entity.Property(e => e.CacheMappingIntParamA).HasColumnName("CacheMapping_IntParamA");

                entity.Property(e => e.CacheMappingIntParamB).HasColumnName("CacheMapping_IntParamB");

                entity.Property(e => e.CacheMappingState).HasColumnName("CacheMapping_State");

                entity.Property(e => e.CacheMappingSyncState).HasColumnName("CacheMapping_SyncState");

                entity.Property(e => e.CacheMappingVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("CacheMapping_VarParamA");

                entity.Property(e => e.CacheMappingVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("CacheMapping_VarParamB");
            });

            modelBuilder.Entity<TbaseCardgroup>(entity =>
            {
                entity.HasKey(e => e.CardGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_cardgroup");

                entity.Property(e => e.CardGroupId).HasColumnName("CardGroup_ID");

                entity.Property(e => e.CardGroupCode).HasColumnName("CardGroup_Code");

                entity.Property(e => e.CardGroupFloatParamA).HasColumnName("CardGroup_FloatParamA");

                entity.Property(e => e.CardGroupFloatParamB).HasColumnName("CardGroup_FloatParamB");

                entity.Property(e => e.CardGroupImg)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("CardGroup_Img")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CardGroupInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CardGroup_InsertDate");

                entity.Property(e => e.CardGroupIntParamA).HasColumnName("CardGroup_IntParamA");

                entity.Property(e => e.CardGroupIntParamB).HasColumnName("CardGroup_IntParamB");

                entity.Property(e => e.CardGroupLink)
                    .HasMaxLength(500)
                    .HasColumnName("CardGroup_Link");

                entity.Property(e => e.CardGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CardGroup_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CardGroupState).HasColumnName("CardGroup_State");

                entity.Property(e => e.CardGroupSyncState).HasColumnName("CardGroup_SyncState");

                entity.Property(e => e.CardGroupThumbnail)
                    .HasMaxLength(200)
                    .HasColumnName("CardGroup_Thumbnail");

                entity.Property(e => e.CardGroupTotal).HasColumnName("CardGroup_Total");

                entity.Property(e => e.CardGroupType).HasColumnName("CardGroup_Type");

                entity.Property(e => e.CardGroupUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CardGroup_UpdateDate");

                entity.Property(e => e.CardGroupVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("CardGroup_VarParamA");

                entity.Property(e => e.CardGroupVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("CardGroup_VarParamB");
            });

            modelBuilder.Entity<TbaseCardgrouppart>(entity =>
            {
                entity.HasKey(e => e.CardGroupPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_cardgrouppart");

                entity.Property(e => e.CardGroupPartId).HasColumnName("CardGroupPart_ID");

                entity.Property(e => e.CardGroupPartCardGroupCode).HasColumnName("CardGroupPart_CardGroupCode");

                entity.Property(e => e.CardGroupPartFloatParamA).HasColumnName("CardGroupPart_FloatParamA");

                entity.Property(e => e.CardGroupPartFloatParamB).HasColumnName("CardGroupPart_FloatParamB");

                entity.Property(e => e.CardGroupPartInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CardGroupPart_InsertDate");

                entity.Property(e => e.CardGroupPartIntParamA).HasColumnName("CardGroupPart_IntParamA");

                entity.Property(e => e.CardGroupPartIntParamB).HasColumnName("CardGroupPart_IntParamB");

                entity.Property(e => e.CardGroupPartNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CardGroupPart_Number")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CardGroupPartState).HasColumnName("CardGroupPart_State");

                entity.Property(e => e.CardGroupPartSyncState).HasColumnName("CardGroupPart_SyncState");

                entity.Property(e => e.CardGroupPartType).HasColumnName("CardGroupPart_Type");

                entity.Property(e => e.CardGroupPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("CardGroupPart_VarParamA");

                entity.Property(e => e.CardGroupPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("CardGroupPart_VarParamB");
            });

            modelBuilder.Entity<TbaseComcredit1>(entity =>
            {
                entity.HasKey(e => e.ComCreditId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_comcredit1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ComCreditCompanyCode, "Index");

                entity.Property(e => e.ComCreditId).HasColumnName("ComCredit_ID");

                entity.Property(e => e.ComCreditAddQuantity).HasColumnName("ComCredit_AddQuantity");

                entity.Property(e => e.ComCreditAmountQuantity).HasColumnName("ComCredit_AmountQuantity");

                entity.Property(e => e.ComCreditCompanyCode).HasColumnName("ComCredit_CompanyCode");

                entity.Property(e => e.ComCreditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ComCredit_Date");

                entity.Property(e => e.ComCreditFloatParamA).HasColumnName("ComCredit_FloatParamA");

                entity.Property(e => e.ComCreditFloatParamB).HasColumnName("ComCredit_FloatParamB");

                entity.Property(e => e.ComCreditIntParamA).HasColumnName("ComCredit_IntParamA");

                entity.Property(e => e.ComCreditIntParamB).HasColumnName("ComCredit_IntParamB");

                entity.Property(e => e.ComCreditRegQuantity).HasColumnName("ComCredit_RegQuantity");

                entity.Property(e => e.ComCreditState).HasColumnName("ComCredit_State");

                entity.Property(e => e.ComCreditText)
                    .HasMaxLength(500)
                    .HasColumnName("ComCredit_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ComCreditVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ComCredit_VarParamA");

                entity.Property(e => e.ComCreditVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ComCredit_VarParamB");
            });

            modelBuilder.Entity<TbaseComcredit2>(entity =>
            {
                entity.HasKey(e => e.ComCreditId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_comcredit2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ComCreditCompanyCode, "Index");

                entity.Property(e => e.ComCreditId).HasColumnName("ComCredit_ID");

                entity.Property(e => e.ComCreditAddQuantity).HasColumnName("ComCredit_AddQuantity");

                entity.Property(e => e.ComCreditAmountQuantity).HasColumnName("ComCredit_AmountQuantity");

                entity.Property(e => e.ComCreditCompanyCode).HasColumnName("ComCredit_CompanyCode");

                entity.Property(e => e.ComCreditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ComCredit_Date");

                entity.Property(e => e.ComCreditFloatParamA).HasColumnName("ComCredit_FloatParamA");

                entity.Property(e => e.ComCreditFloatParamB).HasColumnName("ComCredit_FloatParamB");

                entity.Property(e => e.ComCreditIntParamA).HasColumnName("ComCredit_IntParamA");

                entity.Property(e => e.ComCreditIntParamB).HasColumnName("ComCredit_IntParamB");

                entity.Property(e => e.ComCreditRegQuantity).HasColumnName("ComCredit_RegQuantity");

                entity.Property(e => e.ComCreditState).HasColumnName("ComCredit_State");

                entity.Property(e => e.ComCreditText)
                    .HasMaxLength(500)
                    .HasColumnName("ComCredit_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ComCreditVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ComCredit_VarParamA");

                entity.Property(e => e.ComCreditVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ComCredit_VarParamB");
            });

            modelBuilder.Entity<TbaseComcredit3>(entity =>
            {
                entity.HasKey(e => e.ComCreditId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_comcredit3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ComCreditCompanyCode, "Index");

                entity.Property(e => e.ComCreditId).HasColumnName("ComCredit_ID");

                entity.Property(e => e.ComCreditAddQuantity).HasColumnName("ComCredit_AddQuantity");

                entity.Property(e => e.ComCreditAmountQuantity).HasColumnName("ComCredit_AmountQuantity");

                entity.Property(e => e.ComCreditCompanyCode).HasColumnName("ComCredit_CompanyCode");

                entity.Property(e => e.ComCreditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ComCredit_Date");

                entity.Property(e => e.ComCreditFloatParamA).HasColumnName("ComCredit_FloatParamA");

                entity.Property(e => e.ComCreditFloatParamB).HasColumnName("ComCredit_FloatParamB");

                entity.Property(e => e.ComCreditIntParamA).HasColumnName("ComCredit_IntParamA");

                entity.Property(e => e.ComCreditIntParamB).HasColumnName("ComCredit_IntParamB");

                entity.Property(e => e.ComCreditRegQuantity).HasColumnName("ComCredit_RegQuantity");

                entity.Property(e => e.ComCreditState).HasColumnName("ComCredit_State");

                entity.Property(e => e.ComCreditText)
                    .HasMaxLength(500)
                    .HasColumnName("ComCredit_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ComCreditVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ComCredit_VarParamA");

                entity.Property(e => e.ComCreditVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ComCredit_VarParamB");
            });

            modelBuilder.Entity<TbaseComcreditsum>(entity =>
            {
                entity.HasKey(e => e.ComCreditSumId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_comcreditsum");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ComCreditSumCompanyCode, "Index");

                entity.Property(e => e.ComCreditSumId).HasColumnName("ComCreditSum_ID");

                entity.Property(e => e.ComCreditSumCompanyCode).HasColumnName("ComCreditSum_CompanyCode");

                entity.Property(e => e.ComCreditSumFloatParamA).HasColumnName("ComCreditSum_FloatParamA");

                entity.Property(e => e.ComCreditSumFloatParamB).HasColumnName("ComCreditSum_FloatParamB");

                entity.Property(e => e.ComCreditSumInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ComCreditSum_InsertDate");

                entity.Property(e => e.ComCreditSumIntParamA).HasColumnName("ComCreditSum_IntParamA");

                entity.Property(e => e.ComCreditSumIntParamB).HasColumnName("ComCreditSum_IntParamB");

                entity.Property(e => e.ComCreditSumMemo)
                    .HasColumnType("text")
                    .HasColumnName("ComCreditSum_Memo");

                entity.Property(e => e.ComCreditSumQuantity).HasColumnName("ComCreditSum_Quantity");

                entity.Property(e => e.ComCreditSumState).HasColumnName("ComCreditSum_State");

                entity.Property(e => e.ComCreditSumVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ComCreditSum_VarParamA");

                entity.Property(e => e.ComCreditSumVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ComCreditSum_VarParamB");

                entity.Property(e => e.ComCreditSumVirtualQuantity).HasColumnName("ComCreditSum_VirtualQuantity");
            });

            modelBuilder.Entity<TbaseCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_company");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.CompanyCode, e.CompanyType }, "Index");

                entity.Property(e => e.CompanyId).HasColumnName("Company_ID");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Company_Address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyAllocatefeeA).HasColumnName("Company_AllocatefeeA");

                entity.Property(e => e.CompanyAllocatefeeB).HasColumnName("Company_AllocatefeeB");

                entity.Property(e => e.CompanyBank)
                    .HasMaxLength(10)
                    .HasColumnName("Company_Bank")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyBankAccount)
                    .HasMaxLength(100)
                    .HasColumnName("Company_BankAccount")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyBankAccountName)
                    .HasMaxLength(100)
                    .HasColumnName("Company_BankAccountName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyBankBranch)
                    .HasMaxLength(50)
                    .HasColumnName("Company_BankBranch")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyCity).HasColumnName("Company_City");

                entity.Property(e => e.CompanyCode).HasColumnName("Company_Code");

                entity.Property(e => e.CompanyContactCell)
                    .HasMaxLength(50)
                    .HasColumnName("Company_ContactCell")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyContactEmail)
                    .HasMaxLength(50)
                    .HasColumnName("Company_ContactEmail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyContactName)
                    .HasMaxLength(100)
                    .HasColumnName("Company_ContactName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyContactNameEn)
                    .HasMaxLength(100)
                    .HasColumnName("Company_ContactNameEN")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyContactTel)
                    .HasMaxLength(50)
                    .HasColumnName("Company_ContactTel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyContractStoreDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Company_ContractStoreDate");

                entity.Property(e => e.CompanyContractStoreState).HasColumnName("Company_ContractStoreState");

                entity.Property(e => e.CompanyCountry).HasColumnName("Company_Country");

                entity.Property(e => e.CompanyCountryCode).HasColumnName("Company_CountryCode");

                entity.Property(e => e.CompanyCreditLimit).HasColumnName("Company_CreditLimit");

                entity.Property(e => e.CompanyCurrentDayLimit).HasColumnName("Company_CurrentDayLimit");

                entity.Property(e => e.CompanyCurrentMonthLimit).HasColumnName("Company_CurrentMonthLimit");

                entity.Property(e => e.CompanyDayLimit).HasColumnName("Company_DayLimit");

                entity.Property(e => e.CompanyEachLimit).HasColumnName("Company_EachLimit");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Email")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyEnName)
                    .HasMaxLength(100)
                    .HasColumnName("Company_EnName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyEnShowName)
                    .HasMaxLength(100)
                    .HasColumnName("Company_EnShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyExtCode)
                    .HasMaxLength(36)
                    .HasColumnName("Company_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyFax)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Fax")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyFloatParamA).HasColumnName("Company_FloatParamA");

                entity.Property(e => e.CompanyFloatParamB).HasColumnName("Company_FloatParamB");

                entity.Property(e => e.CompanyGroupNo).HasColumnName("Company_GroupNo");

                entity.Property(e => e.CompanyIdtype).HasColumnName("Company_IDType");

                entity.Property(e => e.CompanyImage)
                    .HasMaxLength(200)
                    .HasColumnName("Company_Image")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Company_InsertDate");

                entity.Property(e => e.CompanyIntParamA).HasColumnName("Company_IntParamA");

                entity.Property(e => e.CompanyIntParamB).HasColumnName("Company_IntParamB");

                entity.Property(e => e.CompanyLocalCityArea).HasColumnName("Company_LocalCityArea");

                entity.Property(e => e.CompanyMonthLimit).HasColumnName("Company_MonthLimit");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Company_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyPassDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Company_PassDate");

                entity.Property(e => e.CompanyPassDealerCode).HasColumnName("Company_PassDealerCode");

                entity.Property(e => e.CompanyPassState).HasColumnName("Company_PassState");

                entity.Property(e => e.CompanyRegisterNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Company_RegisterNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanySettleType).HasColumnName("Company_SettleType");

                entity.Property(e => e.CompanySettlementDay).HasColumnName("Company_SettlementDay");

                entity.Property(e => e.CompanyShowName)
                    .HasMaxLength(100)
                    .HasColumnName("Company_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyState).HasColumnName("Company_State");

                entity.Property(e => e.CompanySyncState).HasColumnName("Company_SyncState");

                entity.Property(e => e.CompanyTaxIdno)
                    .HasMaxLength(50)
                    .HasColumnName("Company_TaxIDNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyTel)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Tel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyType).HasColumnName("Company_Type");

                entity.Property(e => e.CompanyUpCompanyCode).HasColumnName("Company_UpCompanyCode");

                entity.Property(e => e.CompanyUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Company_UpdateDate");

                entity.Property(e => e.CompanyVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Company_VarParamA");

                entity.Property(e => e.CompanyVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Company_VarParamB");

                entity.Property(e => e.CompanyWebSite)
                    .HasMaxLength(100)
                    .HasColumnName("Company_WebSite")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CompanyYearfee).HasColumnName("Company_Yearfee");
            });

            modelBuilder.Entity<TbaseDealstate>(entity =>
            {
                entity.HasKey(e => e.DealStateId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_dealstate");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.DealStateDealTypeCode, e.DealStateCode }, "Index");

                entity.Property(e => e.DealStateId).HasColumnName("DealState_ID");

                entity.Property(e => e.DealStateCode).HasColumnName("DealState_Code");

                entity.Property(e => e.DealStateDealTypeCode).HasColumnName("DealState_DealTypeCode");

                entity.Property(e => e.DealStateFloatParamA).HasColumnName("DealState_FloatParamA");

                entity.Property(e => e.DealStateFloatParamB).HasColumnName("DealState_FloatParamB");

                entity.Property(e => e.DealStateIntParamA).HasColumnName("DealState_IntParamA");

                entity.Property(e => e.DealStateIntParamB).HasColumnName("DealState_IntParamB");

                entity.Property(e => e.DealStateName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("DealState_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealStateShowName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("DealState_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealStateState).HasColumnName("DealState_State");

                entity.Property(e => e.DealStateSyncState).HasColumnName("DealState_SyncState");

                entity.Property(e => e.DealStateVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("DealState_VarParamA");

                entity.Property(e => e.DealStateVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("DealState_VarParamB");
            });

            modelBuilder.Entity<TbaseDealtype>(entity =>
            {
                entity.HasKey(e => e.DealTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_dealtype");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.DealTypeCode, e.DealTypeTableTypeCode }, "Index");

                entity.Property(e => e.DealTypeId).HasColumnName("DealType_ID");

                entity.Property(e => e.DealTypeCode).HasColumnName("DealType_Code");

                entity.Property(e => e.DealTypeFloatParamA).HasColumnName("DealType_FloatParamA");

                entity.Property(e => e.DealTypeFloatParamB).HasColumnName("DealType_FloatParamB");

                entity.Property(e => e.DealTypeIntParamA).HasColumnName("DealType_IntParamA");

                entity.Property(e => e.DealTypeIntParamB).HasColumnName("DealType_IntParamB");

                entity.Property(e => e.DealTypeIsInvalid).HasColumnName("DealType_IsInvalid");

                entity.Property(e => e.DealTypeIsOver).HasColumnName("DealType_IsOver");

                entity.Property(e => e.DealTypeIsSave).HasColumnName("DealType_IsSave");

                entity.Property(e => e.DealTypeJobUrl)
                    .HasMaxLength(200)
                    .HasColumnName("DealType_JobURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealTypeName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("DealType_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealTypeShowName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("DealType_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealTypeState).HasColumnName("DealType_State");

                entity.Property(e => e.DealTypeSyncState).HasColumnName("DealType_SyncState");

                entity.Property(e => e.DealTypeTableTypeCode).HasColumnName("DealType_TableTypeCode");

                entity.Property(e => e.DealTypeUrl)
                    .HasMaxLength(200)
                    .HasColumnName("DealType_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DealTypeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("DealType_VarParamA");

                entity.Property(e => e.DealTypeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("DealType_VarParamB");
            });

            modelBuilder.Entity<TbaseFilecenter>(entity =>
            {
                entity.HasKey(e => e.FileCenterId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_filecenter");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FileCenterId).HasColumnName("FileCenter_ID");

                entity.Property(e => e.FileCenterFile)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("FileCenter_File")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FileCenterFloatParamA).HasColumnName("FileCenter_FloatParamA");

                entity.Property(e => e.FileCenterFloatParamB).HasColumnName("FileCenter_FloatParamB");

                entity.Property(e => e.FileCenterIntParamA).HasColumnName("FileCenter_IntParamA");

                entity.Property(e => e.FileCenterIntParamB).HasColumnName("FileCenter_IntParamB");

                entity.Property(e => e.FileCenterMapTable).HasColumnName("FileCenter_MapTable");

                entity.Property(e => e.FileCenterMapTableCode).HasColumnName("FileCenter_MapTableCode");

                entity.Property(e => e.FileCenterName)
                    .HasMaxLength(200)
                    .HasColumnName("FileCenter_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FileCenterState).HasColumnName("FileCenter_State");

                entity.Property(e => e.FileCenterSyncState).HasColumnName("FileCenter_SyncState");

                entity.Property(e => e.FileCenterType).HasColumnName("FileCenter_Type");

                entity.Property(e => e.FileCenterVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("FileCenter_VarParamA");

                entity.Property(e => e.FileCenterVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("FileCenter_VarParamB");
            });

            modelBuilder.Entity<TbaseFtpdatum>(entity =>
            {
                entity.HasKey(e => e.FtpdataId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_ftpdata");

                entity.Property(e => e.FtpdataId).HasColumnName("FTPData_ID");

                entity.Property(e => e.FtpdataDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FTPData_Date");

                entity.Property(e => e.FtpdataFileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("FTPData_FileName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FtpdataFloatParamA).HasColumnName("FTPData_FloatParamA");

                entity.Property(e => e.FtpdataFloatParamB).HasColumnName("FTPData_FloatParamB");

                entity.Property(e => e.FtpdataIntParamA).HasColumnName("FTPData_IntParamA");

                entity.Property(e => e.FtpdataIntParamB).HasColumnName("FTPData_IntParamB");

                entity.Property(e => e.FtpdataProjectCode).HasColumnName("FTPData_ProjectCode");

                entity.Property(e => e.FtpdataRowData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("FTPData_RowData");

                entity.Property(e => e.FtpdataState).HasColumnName("FTPData_State");

                entity.Property(e => e.FtpdataSyncState).HasColumnName("FTPData_SyncState");

                entity.Property(e => e.FtpdataTemplateState).HasColumnName("FTPData_TemplateState");

                entity.Property(e => e.FtpdataVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("FTPData_VarParamA");

                entity.Property(e => e.FtpdataVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("FTPData_VarParamB");
            });

            modelBuilder.Entity<TbaseJustkacmd>(entity =>
            {
                entity.HasKey(e => e.JustKaCmdId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_justkacmd");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.JustKaCmdId).HasColumnName("JustKaCmd_ID");

                entity.Property(e => e.JustKaCmdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JustKaCmd_Date");

                entity.Property(e => e.JustKaCmdFloatParamA).HasColumnName("JustKaCmd_FloatParamA");

                entity.Property(e => e.JustKaCmdFloatParamB).HasColumnName("JustKaCmd_FloatParamB");

                entity.Property(e => e.JustKaCmdIntParamA).HasColumnName("JustKaCmd_IntParamA");

                entity.Property(e => e.JustKaCmdIntParamB).HasColumnName("JustKaCmd_IntParamB");

                entity.Property(e => e.JustKaCmdMessageDatetime)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("JustKaCmd_messageDatetime")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JustKaCmdMessageId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("JustKaCmd_messageId")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JustKaCmdMuid)
                    .HasMaxLength(100)
                    .HasColumnName("JustKaCmd_muid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JustKaCmdOuid)
                    .HasMaxLength(100)
                    .HasColumnName("JustKaCmd_ouid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JustKaCmdResult).HasColumnName("JustKaCmd_Result");

                entity.Property(e => e.JustKaCmdSuid)
                    .HasMaxLength(100)
                    .HasColumnName("JustKaCmd_suid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JustKaCmdUid)
                    .HasMaxLength(100)
                    .HasColumnName("JustKaCmd_uid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.JustKaCmdVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("JustKaCmd_VarParamA");

                entity.Property(e => e.JustKaCmdVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("JustKaCmd_VarParamB");
            });

            modelBuilder.Entity<TbaseListmap>(entity =>
            {
                entity.HasKey(e => e.ListMapId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_listmap");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ListMapChannelId, e.ListMapProdListCode, e.ListMapUserDefineCode }, "Index");

                entity.Property(e => e.ListMapId).HasColumnName("ListMap_ID");

                entity.Property(e => e.ListMapChannelId).HasColumnName("ListMap_ChannelID");

                entity.Property(e => e.ListMapFloatParamA).HasColumnName("ListMap_FloatParamA");

                entity.Property(e => e.ListMapFloatParamB).HasColumnName("ListMap_FloatParamB");

                entity.Property(e => e.ListMapIntParamA).HasColumnName("ListMap_IntParamA");

                entity.Property(e => e.ListMapIntParamB).HasColumnName("ListMap_IntParamB");

                entity.Property(e => e.ListMapProdListCode).HasColumnName("ListMap_ProdListCode");

                entity.Property(e => e.ListMapSyncState).HasColumnName("ListMap_SyncState");

                entity.Property(e => e.ListMapUserDefineCode).HasColumnName("ListMap_UserDefineCode");

                entity.Property(e => e.ListMapVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ListMap_VarParamA");

                entity.Property(e => e.ListMapVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ListMap_VarParamB");
            });

            modelBuilder.Entity<TbaseMenuinfo>(entity =>
            {
                entity.HasKey(e => e.MenuInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_menuinfo");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.MenuInfoCode, "Index");

                entity.Property(e => e.MenuInfoId).HasColumnName("MenuInfo_ID");

                entity.Property(e => e.MenuInfoAttribute).HasColumnName("MenuInfo_Attribute");

                entity.Property(e => e.MenuInfoCode).HasColumnName("MenuInfo_Code");

                entity.Property(e => e.MenuInfoFloatParamA).HasColumnName("MenuInfo_FloatParamA");

                entity.Property(e => e.MenuInfoFloatParamB).HasColumnName("MenuInfo_FloatParamB");

                entity.Property(e => e.MenuInfoIcon)
                    .HasMaxLength(50)
                    .HasColumnName("MenuInfo_Icon")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MenuInfoIntParamA).HasColumnName("MenuInfo_IntParamA");

                entity.Property(e => e.MenuInfoIntParamB).HasColumnName("MenuInfo_IntParamB");

                entity.Property(e => e.MenuInfoLayNo).HasColumnName("MenuInfo_LayNo");

                entity.Property(e => e.MenuInfoMemo)
                    .HasColumnType("text")
                    .HasColumnName("MenuInfo_Memo");

                entity.Property(e => e.MenuInfoName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MenuInfo_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MenuInfoSort).HasColumnName("MenuInfo_Sort");

                entity.Property(e => e.MenuInfoState).HasColumnName("MenuInfo_State");

                entity.Property(e => e.MenuInfoSyncState).HasColumnName("MenuInfo_SyncState");

                entity.Property(e => e.MenuInfoTableTypeCode).HasColumnName("MenuInfo_TableTypeCode");

                entity.Property(e => e.MenuInfoUpMenuInfoCode).HasColumnName("MenuInfo_UpMenuInfoCode");

                entity.Property(e => e.MenuInfoUrl)
                    .HasMaxLength(500)
                    .HasColumnName("MenuInfo_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MenuInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MenuInfo_VarParamA");

                entity.Property(e => e.MenuInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MenuInfo_VarParamB");
            });

            modelBuilder.Entity<TbaseMenuoperate>(entity =>
            {
                entity.HasKey(e => e.MenuOperateId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_menuoperate");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.MenuOperateCode, e.MenuOperateMenuInfoCode }, "Index");

                entity.Property(e => e.MenuOperateId).HasColumnName("MenuOperate_ID");

                entity.Property(e => e.MenuOperateCode).HasColumnName("MenuOperate_Code");

                entity.Property(e => e.MenuOperateDealTypeCode).HasColumnName("MenuOperate_DealTypeCode");

                entity.Property(e => e.MenuOperateFloatParamA).HasColumnName("MenuOperate_FloatParamA");

                entity.Property(e => e.MenuOperateFloatParamB).HasColumnName("MenuOperate_FloatParamB");

                entity.Property(e => e.MenuOperateIntParamA).HasColumnName("MenuOperate_IntParamA");

                entity.Property(e => e.MenuOperateIntParamB).HasColumnName("MenuOperate_IntParamB");

                entity.Property(e => e.MenuOperateIsLog).HasColumnName("MenuOperate_IsLog");

                entity.Property(e => e.MenuOperateMemo)
                    .HasColumnType("text")
                    .HasColumnName("MenuOperate_Memo");

                entity.Property(e => e.MenuOperateMenuInfoCode).HasColumnName("MenuOperate_MenuInfoCode");

                entity.Property(e => e.MenuOperateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MenuOperate_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MenuOperateState).HasColumnName("MenuOperate_State");

                entity.Property(e => e.MenuOperateSyncState).HasColumnName("MenuOperate_SyncState");

                entity.Property(e => e.MenuOperateTableTypeCode).HasColumnName("MenuOperate_TableTypeCode");

                entity.Property(e => e.MenuOperateType).HasColumnName("MenuOperate_Type");

                entity.Property(e => e.MenuOperateUrl)
                    .HasMaxLength(200)
                    .HasColumnName("MenuOperate_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MenuOperateVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MenuOperate_VarParamA");

                entity.Property(e => e.MenuOperateVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MenuOperate_VarParamB");
            });

            modelBuilder.Entity<TbaseMenuuser>(entity =>
            {
                entity.HasKey(e => e.MenuUserId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_menuuser");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MenuUserId).HasColumnName("MenuUser_ID");

                entity.Property(e => e.MenuUserFloatParamA).HasColumnName("MenuUser_FloatParamA");

                entity.Property(e => e.MenuUserFloatParamB).HasColumnName("MenuUser_FloatParamB");

                entity.Property(e => e.MenuUserIntParamA).HasColumnName("MenuUser_IntParamA");

                entity.Property(e => e.MenuUserIntParamB).HasColumnName("MenuUser_IntParamB");

                entity.Property(e => e.MenuUserMenuInfoCode).HasColumnName("MenuUser_MenuInfoCode");

                entity.Property(e => e.MenuUserMenuOperateCode).HasColumnName("MenuUser_MenuOperateCode");

                entity.Property(e => e.MenuUserRoleInfoCode).HasColumnName("MenuUser_RoleInfoCode");

                entity.Property(e => e.MenuUserSyncState).HasColumnName("MenuUser_SyncState");

                entity.Property(e => e.MenuUserType).HasColumnName("MenuUser_Type");

                entity.Property(e => e.MenuUserUserInfoCode).HasColumnName("MenuUser_UserInfoCode");

                entity.Property(e => e.MenuUserVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MenuUser_VarParamA");

                entity.Property(e => e.MenuUserVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MenuUser_VarParamB");
            });

            modelBuilder.Entity<TbaseNoticelog>(entity =>
            {
                entity.HasKey(e => e.NoticeLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_noticelog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NoticeLogId).HasColumnName("NoticeLog_ID");

                entity.Property(e => e.NoticeLogCheckCode)
                    .HasMaxLength(100)
                    .HasColumnName("NoticeLog_CheckCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.NoticeLogContect)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("NoticeLog_Contect");

                entity.Property(e => e.NoticeLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NoticeLog_Date");

                entity.Property(e => e.NoticeLogFromAccount)
                    .HasMaxLength(50)
                    .HasColumnName("NoticeLog_FromAccount")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.NoticeLogFromCode).HasColumnName("NoticeLog_FromCode");

                entity.Property(e => e.NoticeLogFromEccode).HasColumnName("NoticeLog_FromECCode");

                entity.Property(e => e.NoticeLogLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NoticeLog_LimitDate");

                entity.Property(e => e.NoticeLogMode).HasColumnName("NoticeLog_Mode");

                entity.Property(e => e.NoticeLogResult)
                    .HasColumnType("text")
                    .HasColumnName("NoticeLog_Result");

                entity.Property(e => e.NoticeLogSendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NoticeLog_SendDate");

                entity.Property(e => e.NoticeLogSendState).HasColumnName("NoticeLog_SendState");

                entity.Property(e => e.NoticeLogState).HasColumnName("NoticeLog_State");

                entity.Property(e => e.NoticeLogTitle)
                    .HasMaxLength(50)
                    .HasColumnName("NoticeLog_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.NoticeLogTo)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("NoticeLog_To")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.NoticeLogToExtCode)
                    .HasMaxLength(20)
                    .HasColumnName("NoticeLog_ToExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.NoticeLogToUserCode).HasColumnName("NoticeLog_ToUserCode");

                entity.Property(e => e.NoticeLogType).HasColumnName("NoticeLog_Type");
            });

            modelBuilder.Entity<TbasePayset>(entity =>
            {
                entity.HasKey(e => e.PaySetId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_payset");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaySetId).HasColumnName("PaySet_ID");

                entity.Property(e => e.PaySetCode).HasColumnName("PaySet_Code");

                entity.Property(e => e.PaySetCspaymentId).HasColumnName("PaySet_CSPaymentID");

                entity.Property(e => e.PaySetEcstoreCode).HasColumnName("PaySet_ECStoreCode");

                entity.Property(e => e.PaySetFloatParamA).HasColumnName("PaySet_FloatParamA");

                entity.Property(e => e.PaySetFloatParamB).HasColumnName("PaySet_FloatParamB");

                entity.Property(e => e.PaySetFloatParamC).HasColumnName("PaySet_FloatParamC");

                entity.Property(e => e.PaySetInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PaySet_InsertDate");

                entity.Property(e => e.PaySetIntParamA).HasColumnName("PaySet_IntParamA");

                entity.Property(e => e.PaySetIntParamB).HasColumnName("PaySet_IntParamB");

                entity.Property(e => e.PaySetIntParamC).HasColumnName("PaySet_IntParamC");

                entity.Property(e => e.PaySetMemo)
                    .HasMaxLength(500)
                    .HasColumnName("PaySet_Memo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PaySetName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PaySet_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PaySetPaymentType).HasColumnName("PaySet_PaymentType");

                entity.Property(e => e.PaySetState).HasColumnName("PaySet_State");

                entity.Property(e => e.PaySetVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PaySet_VarParamA");

                entity.Property(e => e.PaySetVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PaySet_VarParamB");

                entity.Property(e => e.PaySetVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("PaySet_VarParamC");
            });

            modelBuilder.Entity<TbasePaysetitem>(entity =>
            {
                entity.HasKey(e => e.PaySetItemId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_paysetitem");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaySetItemId).HasColumnName("PaySetItem_ID");

                entity.Property(e => e.PaySetItemAmount).HasColumnName("PaySetItem_Amount");

                entity.Property(e => e.PaySetItemCalculateType).HasColumnName("PaySetItem_CalculateType");

                entity.Property(e => e.PaySetItemCode).HasColumnName("PaySetItem_Code");

                entity.Property(e => e.PaySetItemExtName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PaySetItem_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PaySetItemFeeType).HasColumnName("PaySetItem_FeeType");

                entity.Property(e => e.PaySetItemFloatParamA).HasColumnName("PaySetItem_FloatParamA");

                entity.Property(e => e.PaySetItemFloatParamB).HasColumnName("PaySetItem_FloatParamB");

                entity.Property(e => e.PaySetItemFloatParamC).HasColumnName("PaySetItem_FloatParamC");

                entity.Property(e => e.PaySetItemInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PaySetItem_InsertDate");

                entity.Property(e => e.PaySetItemIntParamA).HasColumnName("PaySetItem_IntParamA");

                entity.Property(e => e.PaySetItemIntParamB).HasColumnName("PaySetItem_IntParamB");

                entity.Property(e => e.PaySetItemIntParamC).HasColumnName("PaySetItem_IntParamC");

                entity.Property(e => e.PaySetItemMaxAmount).HasColumnName("PaySetItem_MaxAmount");

                entity.Property(e => e.PaySetItemMinAmount).HasColumnName("PaySetItem_MinAmount");

                entity.Property(e => e.PaySetItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PaySetItem_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PaySetItemPaySetCode).HasColumnName("PaySetItem_PaySetCode");

                entity.Property(e => e.PaySetItemPaymentClass).HasColumnName("PaySetItem_PaymentClass");

                entity.Property(e => e.PaySetItemPaymentSetClass).HasColumnName("PaySetItem_PaymentSetClass");

                entity.Property(e => e.PaySetItemSort).HasColumnName("PaySetItem_Sort");

                entity.Property(e => e.PaySetItemState).HasColumnName("PaySetItem_State");

                entity.Property(e => e.PaySetItemVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PaySetItem_VarParamA");

                entity.Property(e => e.PaySetItemVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PaySetItem_VarParamB");

                entity.Property(e => e.PaySetItemVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("PaySetItem_VarParamC");
            });

            modelBuilder.Entity<TbaseProdattr>(entity =>
            {
                entity.HasKey(e => e.ProdAttrId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_prodattr");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ProdAttrProductCode, e.ProdAttrAttributeCode, e.ProdAttrAttributeValueCode }, "Index");

                entity.Property(e => e.ProdAttrId).HasColumnName("ProdAttr_ID");

                entity.Property(e => e.ProdAttrAttributeCode).HasColumnName("ProdAttr_AttributeCode");

                entity.Property(e => e.ProdAttrAttributeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ProdAttr_AttributeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdAttrAttributeType).HasColumnName("ProdAttr_AttributeType");

                entity.Property(e => e.ProdAttrAttributeValueCode).HasColumnName("ProdAttr_AttributeValueCode");

                entity.Property(e => e.ProdAttrAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ProdAttr_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdAttrFloatParamA).HasColumnName("ProdAttr_FloatParamA");

                entity.Property(e => e.ProdAttrFloatParamB).HasColumnName("ProdAttr_FloatParamB");

                entity.Property(e => e.ProdAttrIntParamA).HasColumnName("ProdAttr_IntParamA");

                entity.Property(e => e.ProdAttrIntParamB).HasColumnName("ProdAttr_IntParamB");

                entity.Property(e => e.ProdAttrIsShow).HasColumnName("ProdAttr_IsShow");

                entity.Property(e => e.ProdAttrProductCode).HasColumnName("ProdAttr_ProductCode");

                entity.Property(e => e.ProdAttrSyncState).HasColumnName("ProdAttr_SyncState");

                entity.Property(e => e.ProdAttrVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProdAttr_VarParamA");

                entity.Property(e => e.ProdAttrVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProdAttr_VarParamB");
            });

            modelBuilder.Entity<TbaseProdlist>(entity =>
            {
                entity.HasKey(e => e.ProdListId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_prodlist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ProdListCode, "Index");

                entity.Property(e => e.ProdListId).HasColumnName("ProdList_ID");

                entity.Property(e => e.ProdListAttribute).HasColumnName("ProdList_Attribute");

                entity.Property(e => e.ProdListCode).HasColumnName("ProdList_Code");

                entity.Property(e => e.ProdListFloatParamA).HasColumnName("ProdList_FloatParamA");

                entity.Property(e => e.ProdListFloatParamB).HasColumnName("ProdList_FloatParamB");

                entity.Property(e => e.ProdListIntParamA).HasColumnName("ProdList_IntParamA");

                entity.Property(e => e.ProdListIntParamB).HasColumnName("ProdList_IntParamB");

                entity.Property(e => e.ProdListLayNo).HasColumnName("ProdList_LayNo");

                entity.Property(e => e.ProdListMemo)
                    .HasColumnType("text")
                    .HasColumnName("ProdList_Memo");

                entity.Property(e => e.ProdListName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("ProdList_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListPicUrl1)
                    .HasMaxLength(200)
                    .HasColumnName("ProdList_PicUrl1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListPicUrl2)
                    .HasMaxLength(200)
                    .HasColumnName("ProdList_PicUrl2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListPicUrl3)
                    .HasMaxLength(200)
                    .HasColumnName("ProdList_PicUrl3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListPicUrl4)
                    .HasMaxLength(200)
                    .HasColumnName("ProdList_PicUrl4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListPicUrl5)
                    .HasMaxLength(200)
                    .HasColumnName("ProdList_PicUrl5")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListState).HasColumnName("ProdList_State");

                entity.Property(e => e.ProdListSyncState).HasColumnName("ProdList_SyncState");

                entity.Property(e => e.ProdListTemplateState).HasColumnName("ProdList_TemplateState");

                entity.Property(e => e.ProdListUpProdListCode).HasColumnName("ProdList_UpProdListCode");

                entity.Property(e => e.ProdListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProdList_VarParamA");

                entity.Property(e => e.ProdListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProdList_VarParamB");
            });

            modelBuilder.Entity<TbaseProdlistattrmap>(entity =>
            {
                entity.HasKey(e => e.ProdListAttrMapId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_prodlistattrmap");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ProdListAttrMapProdListCode, e.ProdListAttrMapAttributeCode, e.ProdListAttrMapAttributeValueCode, e.ProdListAttrMapMode }, "Index");

                entity.Property(e => e.ProdListAttrMapId).HasColumnName("ProdListAttrMap_ID");

                entity.Property(e => e.ProdListAttrMapAttributeCode).HasColumnName("ProdListAttrMap_AttributeCode");

                entity.Property(e => e.ProdListAttrMapAttributeColor)
                    .HasMaxLength(50)
                    .HasColumnName("ProdListAttrMap_AttributeColor")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListAttrMapAttributeName)
                    .HasMaxLength(50)
                    .HasColumnName("ProdListAttrMap_AttributeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListAttrMapAttributeValueCode).HasColumnName("ProdListAttrMap_AttributeValueCode");

                entity.Property(e => e.ProdListAttrMapAttributeValueName)
                    .HasMaxLength(50)
                    .HasColumnName("ProdListAttrMap_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProdListAttrMapFloatParamA).HasColumnName("ProdListAttrMap_FloatParamA");

                entity.Property(e => e.ProdListAttrMapFloatParamB).HasColumnName("ProdListAttrMap_FloatParamB");

                entity.Property(e => e.ProdListAttrMapIntParamA).HasColumnName("ProdListAttrMap_IntParamA");

                entity.Property(e => e.ProdListAttrMapIntParamB).HasColumnName("ProdListAttrMap_IntParamB");

                entity.Property(e => e.ProdListAttrMapIsShow).HasColumnName("ProdListAttrMap_IsShow");

                entity.Property(e => e.ProdListAttrMapMode).HasColumnName("ProdListAttrMap_Mode");

                entity.Property(e => e.ProdListAttrMapProdCount).HasColumnName("ProdListAttrMap_ProdCount");

                entity.Property(e => e.ProdListAttrMapProdListCode).HasColumnName("ProdListAttrMap_ProdListCode");

                entity.Property(e => e.ProdListAttrMapSyncState).HasColumnName("ProdListAttrMap_SyncState");

                entity.Property(e => e.ProdListAttrMapVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProdListAttrMap_VarParamA");

                entity.Property(e => e.ProdListAttrMapVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProdListAttrMap_VarParamB");
            });

            modelBuilder.Entity<TbaseProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_product");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ProductCode, e.ProductCountryCode, e.ProductName, e.ProductType, e.ProductEcstoreCode }, "Index");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.ProductClick).HasColumnName("Product_Click");

                entity.Property(e => e.ProductCode).HasColumnName("Product_Code");

                entity.Property(e => e.ProductCostPrice).HasColumnName("Product_CostPrice");

                entity.Property(e => e.ProductCountryCode).HasColumnName("Product_CountryCode");

                entity.Property(e => e.ProductDepiction)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Product_Depiction");

                entity.Property(e => e.ProductDiscountCoin).HasColumnName("Product_DiscountCoin");

                entity.Property(e => e.ProductEcstoreCode).HasColumnName("Product_ECStoreCode");

                entity.Property(e => e.ProductExClass).HasColumnName("Product_ExClass");

                entity.Property(e => e.ProductExtCode)
                    .HasMaxLength(50)
                    .HasColumnName("Product_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductExtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Product_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductFloatParamA).HasColumnName("Product_FloatParamA");

                entity.Property(e => e.ProductFloatParamB).HasColumnName("Product_FloatParamB");

                entity.Property(e => e.ProductFlowState).HasColumnName("Product_FlowState");

                entity.Property(e => e.ProductIcon)
                    .HasMaxLength(200)
                    .HasColumnName("Product_Icon")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductIntParamA).HasColumnName("Product_IntParamA");

                entity.Property(e => e.ProductIntParamB).HasColumnName("Product_IntParamB");

                entity.Property(e => e.ProductIsHot).HasColumnName("Product_IsHot");

                entity.Property(e => e.ProductIsOnline).HasColumnName("Product_IsOnline");

                entity.Property(e => e.ProductJson)
                    .HasColumnType("text")
                    .HasColumnName("Product_Json");

                entity.Property(e => e.ProductKeyWord)
                    .HasMaxLength(500)
                    .HasColumnName("Product_KeyWord")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductMemo)
                    .HasColumnType("text")
                    .HasColumnName("Product_Memo");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Product_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductOfflineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Product_OfflineDate");

                entity.Property(e => e.ProductOnlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Product_OnlineDate");

                entity.Property(e => e.ProductOrderNotice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Product_OrderNotice");

                entity.Property(e => e.ProductPassState).HasColumnName("Product_PassState");

                entity.Property(e => e.ProductPrimeImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Product_PrimeImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductReceiptPrice).HasColumnName("Product_ReceiptPrice");

                entity.Property(e => e.ProductReceiptText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Product_ReceiptText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductSellPrice).HasColumnName("Product_SellPrice");

                entity.Property(e => e.ProductSellUnit).HasColumnName("Product_SellUnit");

                entity.Property(e => e.ProductShopping)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Product_Shopping");

                entity.Property(e => e.ProductSort1).HasColumnName("Product_Sort1");

                entity.Property(e => e.ProductSort2).HasColumnName("Product_Sort2");

                entity.Property(e => e.ProductSpecialOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Product_SpecialOffDate");

                entity.Property(e => e.ProductSpecialOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Product_SpecialOnDate");

                entity.Property(e => e.ProductSpecialPrice).HasColumnName("Product_SpecialPrice");

                entity.Property(e => e.ProductState).HasColumnName("Product_State");

                entity.Property(e => e.ProductStockWarning).HasColumnName("Product_StockWarning");

                entity.Property(e => e.ProductSupplierCode).HasColumnName("Product_SupplierCode");

                entity.Property(e => e.ProductSyncState).HasColumnName("Product_SyncState");

                entity.Property(e => e.ProductTemplateState).HasColumnName("Product_TemplateState");

                entity.Property(e => e.ProductType).HasColumnName("Product_Type");

                entity.Property(e => e.ProductUrl)
                    .HasMaxLength(500)
                    .HasColumnName("Product_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Product_UsedOffDate");

                entity.Property(e => e.ProductUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Product_UsedOnDate");

                entity.Property(e => e.ProductVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Product_VarParamA");

                entity.Property(e => e.ProductVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Product_VarParamB");
            });

            modelBuilder.Entity<TbaseProductgiveaway>(entity =>
            {
                entity.HasKey(e => e.ProductGiveawayId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_productgiveaway");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ProductGiveawayProductCode, e.ProductGiveawayGiveawayCode }, "Index");

                entity.Property(e => e.ProductGiveawayId).HasColumnName("ProductGiveaway_ID");

                entity.Property(e => e.ProductGiveawayCount).HasColumnName("ProductGiveaway_Count");

                entity.Property(e => e.ProductGiveawayFloatParamA).HasColumnName("ProductGiveaway_FloatParamA");

                entity.Property(e => e.ProductGiveawayFloatParamB).HasColumnName("ProductGiveaway_FloatParamB");

                entity.Property(e => e.ProductGiveawayGiveawayCode).HasColumnName("ProductGiveaway_GiveawayCode");

                entity.Property(e => e.ProductGiveawayIntParamA).HasColumnName("ProductGiveaway_IntParamA");

                entity.Property(e => e.ProductGiveawayIntParamB).HasColumnName("ProductGiveaway_IntParamB");

                entity.Property(e => e.ProductGiveawayProductCode).HasColumnName("ProductGiveaway_ProductCode");

                entity.Property(e => e.ProductGiveawaySyncState).HasColumnName("ProductGiveaway_SyncState");

                entity.Property(e => e.ProductGiveawayVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProductGiveaway_VarParamA");

                entity.Property(e => e.ProductGiveawayVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProductGiveaway_VarParamB");
            });

            modelBuilder.Entity<TbaseProductimg>(entity =>
            {
                entity.HasKey(e => e.ProductImgId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_productimg");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.ProductImgProductCode, "Index");

                entity.Property(e => e.ProductImgId).HasColumnName("ProductImg_ID");

                entity.Property(e => e.ProductImgExplain)
                    .HasMaxLength(500)
                    .HasColumnName("ProductImg_Explain")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductImgFloatParamA).HasColumnName("ProductImg_FloatParamA");

                entity.Property(e => e.ProductImgFloatParamB).HasColumnName("ProductImg_FloatParamB");

                entity.Property(e => e.ProductImgImgUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("ProductImg_ImgUrl")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductImgIntParamA).HasColumnName("ProductImg_IntParamA");

                entity.Property(e => e.ProductImgIntParamB).HasColumnName("ProductImg_IntParamB");

                entity.Property(e => e.ProductImgIsAffiliated).HasColumnName("ProductImg_IsAffiliated");

                entity.Property(e => e.ProductImgProductCode).HasColumnName("ProductImg_ProductCode");

                entity.Property(e => e.ProductImgState).HasColumnName("ProductImg_State");

                entity.Property(e => e.ProductImgSyncState).HasColumnName("ProductImg_SyncState");

                entity.Property(e => e.ProductImgVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProductImg_VarParamA");

                entity.Property(e => e.ProductImgVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProductImg_VarParamB");
            });

            modelBuilder.Entity<TbaseProductlog>(entity =>
            {
                entity.HasKey(e => e.ProductLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_productlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProductLogId).HasColumnName("ProductLog_ID");

                entity.Property(e => e.ProductLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ProductLog_Date");

                entity.Property(e => e.ProductLogDealerName)
                    .HasMaxLength(30)
                    .HasColumnName("ProductLog_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductLogFloatParamA).HasColumnName("ProductLog_FloatParamA");

                entity.Property(e => e.ProductLogFloatParamB).HasColumnName("ProductLog_FloatParamB");

                entity.Property(e => e.ProductLogIntParamA).HasColumnName("ProductLog_IntParamA");

                entity.Property(e => e.ProductLogIntParamB).HasColumnName("ProductLog_IntParamB");

                entity.Property(e => e.ProductLogJsonProduct)
                    .HasColumnType("text")
                    .HasColumnName("ProductLog_JsonProduct");

                entity.Property(e => e.ProductLogMemo)
                    .HasColumnType("text")
                    .HasColumnName("ProductLog_Memo");

                entity.Property(e => e.ProductLogProdActionState).HasColumnName("ProductLog_ProdActionState");

                entity.Property(e => e.ProductLogProdPassState).HasColumnName("ProductLog_ProdPassState");

                entity.Property(e => e.ProductLogProductCode).HasColumnName("ProductLog_ProductCode");

                entity.Property(e => e.ProductLogSyncState).HasColumnName("ProductLog_SyncState");

                entity.Property(e => e.ProductLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProductLog_VarParamA");

                entity.Property(e => e.ProductLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProductLog_VarParamB");
            });

            modelBuilder.Entity<TbaseProductprodlist>(entity =>
            {
                entity.HasKey(e => e.ProductProdListId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_productprodlist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ProductProdListProdListCode, e.ProductProdListProductCode, e.ProductProdListMode }, "Index");

                entity.Property(e => e.ProductProdListId).HasColumnName("ProductProdList_ID");

                entity.Property(e => e.ProductProdListFloatParamA).HasColumnName("ProductProdList_FloatParamA");

                entity.Property(e => e.ProductProdListFloatParamB).HasColumnName("ProductProdList_FloatParamB");

                entity.Property(e => e.ProductProdListIntParamA).HasColumnName("ProductProdList_IntParamA");

                entity.Property(e => e.ProductProdListIntParamB).HasColumnName("ProductProdList_IntParamB");

                entity.Property(e => e.ProductProdListMode).HasColumnName("ProductProdList_Mode");

                entity.Property(e => e.ProductProdListProdListCode).HasColumnName("ProductProdList_ProdListCode");

                entity.Property(e => e.ProductProdListProductCode).HasColumnName("ProductProdList_ProductCode");

                entity.Property(e => e.ProductProdListSyncState).HasColumnName("ProductProdList_SyncState");

                entity.Property(e => e.ProductProdListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ProductProdList_VarParamA");

                entity.Property(e => e.ProductProdListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ProductProdList_VarParamB");
            });

            modelBuilder.Entity<TbaseRoleinfo>(entity =>
            {
                entity.HasKey(e => e.RoleInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_roleinfo");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.RoleInfoCode, "Index");

                entity.Property(e => e.RoleInfoId).HasColumnName("RoleInfo_ID");

                entity.Property(e => e.RoleInfoCode).HasColumnName("RoleInfo_Code");

                entity.Property(e => e.RoleInfoFloatParamA).HasColumnName("RoleInfo_FloatParamA");

                entity.Property(e => e.RoleInfoFloatParamB).HasColumnName("RoleInfo_FloatParamB");

                entity.Property(e => e.RoleInfoIntParamA).HasColumnName("RoleInfo_IntParamA");

                entity.Property(e => e.RoleInfoIntParamB).HasColumnName("RoleInfo_IntParamB");

                entity.Property(e => e.RoleInfoMemo)
                    .HasMaxLength(500)
                    .HasColumnName("RoleInfo_Memo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RoleInfoName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("RoleInfo_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RoleInfoState).HasColumnName("RoleInfo_State");

                entity.Property(e => e.RoleInfoSyncState).HasColumnName("RoleInfo_SyncState");

                entity.Property(e => e.RoleInfoType).HasColumnName("RoleInfo_Type");

                entity.Property(e => e.RoleInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("RoleInfo_VarParamA");

                entity.Property(e => e.RoleInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("RoleInfo_VarParamB");
            });

            modelBuilder.Entity<TbaseTabletype>(entity =>
            {
                entity.HasKey(e => e.TableTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_tabletype");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.TableTypeCode, e.TableTypeWorkflowId }, "Index");

                entity.Property(e => e.TableTypeId).HasColumnName("TableType_ID");

                entity.Property(e => e.TableTypeCode).HasColumnName("TableType_Code");

                entity.Property(e => e.TableTypeDescription)
                    .HasMaxLength(200)
                    .HasColumnName("TableType_Description")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableTypeExtUrl)
                    .HasMaxLength(200)
                    .HasColumnName("TableType_ExtURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableTypeFloatParamA).HasColumnName("TableType_FloatParamA");

                entity.Property(e => e.TableTypeFloatParamB).HasColumnName("TableType_FloatParamB");

                entity.Property(e => e.TableTypeGroupNo).HasColumnName("TableType_GroupNo");

                entity.Property(e => e.TableTypeHead)
                    .HasMaxLength(100)
                    .HasColumnName("TableType_Head")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableTypeIntParamA).HasColumnName("TableType_IntParamA");

                entity.Property(e => e.TableTypeIntParamB).HasColumnName("TableType_IntParamB");

                entity.Property(e => e.TableTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TableType_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableTypeShowName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TableType_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableTypeState).HasColumnName("TableType_State");

                entity.Property(e => e.TableTypeSyncState).HasColumnName("TableType_SyncState");

                entity.Property(e => e.TableTypeUrl)
                    .HasMaxLength(200)
                    .HasColumnName("TableType_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TableTypeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("TableType_VarParamA");

                entity.Property(e => e.TableTypeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("TableType_VarParamB");

                entity.Property(e => e.TableTypeWorkflowId).HasColumnName("TableType_WorkflowID");
            });

            modelBuilder.Entity<TbaseUserauthstore1>(entity =>
            {
                entity.HasKey(e => e.UserAuthStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userauthstore1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserAuthStoreUserInfoCode, e.UserAuthStoreAuthStoreCode }, "Index");

                entity.Property(e => e.UserAuthStoreId).HasColumnName("UserAuthStore_ID");

                entity.Property(e => e.UserAuthStoreAuthStoreCode).HasColumnName("UserAuthStore_AuthStoreCode");

                entity.Property(e => e.UserAuthStoreCode).HasColumnName("UserAuthStore_Code");

                entity.Property(e => e.UserAuthStoreDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserAuthStore_Date");

                entity.Property(e => e.UserAuthStoreFloatParamA).HasColumnName("UserAuthStore_FloatParamA");

                entity.Property(e => e.UserAuthStoreFloatParamB).HasColumnName("UserAuthStore_FloatParamB");

                entity.Property(e => e.UserAuthStoreIntParamA).HasColumnName("UserAuthStore_IntParamA");

                entity.Property(e => e.UserAuthStoreIntParamB).HasColumnName("UserAuthStore_IntParamB");

                entity.Property(e => e.UserAuthStoreLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserAuthStore_LimitDate");

                entity.Property(e => e.UserAuthStoreState).HasColumnName("UserAuthStore_State");

                entity.Property(e => e.UserAuthStoreToken)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("UserAuthStore_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserAuthStoreUserInfoCode).HasColumnName("UserAuthStore_UserInfoCode");

                entity.Property(e => e.UserAuthStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserAuthStore_VarParamA");

                entity.Property(e => e.UserAuthStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserAuthStore_VarParamB");
            });

            modelBuilder.Entity<TbaseUserauthstore2>(entity =>
            {
                entity.HasKey(e => e.UserAuthStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userauthstore2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserAuthStoreUserInfoCode, e.UserAuthStoreAuthStoreCode }, "Index");

                entity.Property(e => e.UserAuthStoreId).HasColumnName("UserAuthStore_ID");

                entity.Property(e => e.UserAuthStoreAuthStoreCode).HasColumnName("UserAuthStore_AuthStoreCode");

                entity.Property(e => e.UserAuthStoreCode).HasColumnName("UserAuthStore_Code");

                entity.Property(e => e.UserAuthStoreDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserAuthStore_Date");

                entity.Property(e => e.UserAuthStoreFloatParamA).HasColumnName("UserAuthStore_FloatParamA");

                entity.Property(e => e.UserAuthStoreFloatParamB).HasColumnName("UserAuthStore_FloatParamB");

                entity.Property(e => e.UserAuthStoreIntParamA).HasColumnName("UserAuthStore_IntParamA");

                entity.Property(e => e.UserAuthStoreIntParamB).HasColumnName("UserAuthStore_IntParamB");

                entity.Property(e => e.UserAuthStoreLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserAuthStore_LimitDate");

                entity.Property(e => e.UserAuthStoreState).HasColumnName("UserAuthStore_State");

                entity.Property(e => e.UserAuthStoreToken)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("UserAuthStore_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserAuthStoreUserInfoCode).HasColumnName("UserAuthStore_UserInfoCode");

                entity.Property(e => e.UserAuthStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserAuthStore_VarParamA");

                entity.Property(e => e.UserAuthStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserAuthStore_VarParamB");
            });

            modelBuilder.Entity<TbaseUserauthstore3>(entity =>
            {
                entity.HasKey(e => e.UserAuthStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userauthstore3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserAuthStoreUserInfoCode, e.UserAuthStoreAuthStoreCode }, "Index");

                entity.Property(e => e.UserAuthStoreId).HasColumnName("UserAuthStore_ID");

                entity.Property(e => e.UserAuthStoreAuthStoreCode).HasColumnName("UserAuthStore_AuthStoreCode");

                entity.Property(e => e.UserAuthStoreCode).HasColumnName("UserAuthStore_Code");

                entity.Property(e => e.UserAuthStoreDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserAuthStore_Date");

                entity.Property(e => e.UserAuthStoreFloatParamA).HasColumnName("UserAuthStore_FloatParamA");

                entity.Property(e => e.UserAuthStoreFloatParamB).HasColumnName("UserAuthStore_FloatParamB");

                entity.Property(e => e.UserAuthStoreIntParamA).HasColumnName("UserAuthStore_IntParamA");

                entity.Property(e => e.UserAuthStoreIntParamB).HasColumnName("UserAuthStore_IntParamB");

                entity.Property(e => e.UserAuthStoreLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserAuthStore_LimitDate");

                entity.Property(e => e.UserAuthStoreState).HasColumnName("UserAuthStore_State");

                entity.Property(e => e.UserAuthStoreToken)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("UserAuthStore_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserAuthStoreUserInfoCode).HasColumnName("UserAuthStore_UserInfoCode");

                entity.Property(e => e.UserAuthStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserAuthStore_VarParamA");

                entity.Property(e => e.UserAuthStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserAuthStore_VarParamB");
            });

            modelBuilder.Entity<TbaseUsercardchangelog1>(entity =>
            {
                entity.HasKey(e => e.UserCardChangeLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usercardchangelog1");

                entity.Property(e => e.UserCardChangeLogId).HasColumnName("UserCardChangeLog_ID");

                entity.Property(e => e.UserCardChangeLogCardCode)
                    .HasMaxLength(50)
                    .HasColumnName("UserCardChangeLog_CardCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserCardChangeLogCardName)
                    .HasMaxLength(50)
                    .HasColumnName("UserCardChangeLog_CardName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserCardChangeLogCardType).HasColumnName("UserCardChangeLog_CardType");

                entity.Property(e => e.UserCardChangeLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardChangeLog_Date");

                entity.Property(e => e.UserCardChangeLogFloatParamA).HasColumnName("UserCardChangeLog_FloatParamA");

                entity.Property(e => e.UserCardChangeLogFloatParamB).HasColumnName("UserCardChangeLog_FloatParamB");

                entity.Property(e => e.UserCardChangeLogIntParamA).HasColumnName("UserCardChangeLog_IntParamA");

                entity.Property(e => e.UserCardChangeLogIntParamB).HasColumnName("UserCardChangeLog_IntParamB");

                entity.Property(e => e.UserCardChangeLogSyncState).HasColumnName("UserCardChangeLog_SyncState");

                entity.Property(e => e.UserCardChangeLogType).HasColumnName("UserCardChangeLog_Type");

                entity.Property(e => e.UserCardChangeLogUserFavouriteId).HasColumnName("UserCardChangeLog_UserFavouriteID");

                entity.Property(e => e.UserCardChangeLogUserInfoCode).HasColumnName("UserCardChangeLog_UserInfoCode");

                entity.Property(e => e.UserCardChangeLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserCardChangeLog_VarParamA");

                entity.Property(e => e.UserCardChangeLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserCardChangeLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUsercardchangelog2>(entity =>
            {
                entity.HasKey(e => e.UserCardChangeLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usercardchangelog2");

                entity.Property(e => e.UserCardChangeLogId).HasColumnName("UserCardChangeLog_ID");

                entity.Property(e => e.UserCardChangeLogCardCode)
                    .HasMaxLength(50)
                    .HasColumnName("UserCardChangeLog_CardCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserCardChangeLogCardName)
                    .HasMaxLength(50)
                    .HasColumnName("UserCardChangeLog_CardName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserCardChangeLogCardType).HasColumnName("UserCardChangeLog_CardType");

                entity.Property(e => e.UserCardChangeLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardChangeLog_Date");

                entity.Property(e => e.UserCardChangeLogFloatParamA).HasColumnName("UserCardChangeLog_FloatParamA");

                entity.Property(e => e.UserCardChangeLogFloatParamB).HasColumnName("UserCardChangeLog_FloatParamB");

                entity.Property(e => e.UserCardChangeLogIntParamA).HasColumnName("UserCardChangeLog_IntParamA");

                entity.Property(e => e.UserCardChangeLogIntParamB).HasColumnName("UserCardChangeLog_IntParamB");

                entity.Property(e => e.UserCardChangeLogSyncState).HasColumnName("UserCardChangeLog_SyncState");

                entity.Property(e => e.UserCardChangeLogType).HasColumnName("UserCardChangeLog_Type");

                entity.Property(e => e.UserCardChangeLogUserFavouriteId).HasColumnName("UserCardChangeLog_UserFavouriteID");

                entity.Property(e => e.UserCardChangeLogUserInfoCode).HasColumnName("UserCardChangeLog_UserInfoCode");

                entity.Property(e => e.UserCardChangeLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserCardChangeLog_VarParamA");

                entity.Property(e => e.UserCardChangeLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserCardChangeLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUsercardchangelog3>(entity =>
            {
                entity.HasKey(e => e.UserCardChangeLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usercardchangelog3");

                entity.Property(e => e.UserCardChangeLogId).HasColumnName("UserCardChangeLog_ID");

                entity.Property(e => e.UserCardChangeLogCardCode)
                    .HasMaxLength(50)
                    .HasColumnName("UserCardChangeLog_CardCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserCardChangeLogCardName)
                    .HasMaxLength(50)
                    .HasColumnName("UserCardChangeLog_CardName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserCardChangeLogCardType).HasColumnName("UserCardChangeLog_CardType");

                entity.Property(e => e.UserCardChangeLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardChangeLog_Date");

                entity.Property(e => e.UserCardChangeLogFloatParamA).HasColumnName("UserCardChangeLog_FloatParamA");

                entity.Property(e => e.UserCardChangeLogFloatParamB).HasColumnName("UserCardChangeLog_FloatParamB");

                entity.Property(e => e.UserCardChangeLogIntParamA).HasColumnName("UserCardChangeLog_IntParamA");

                entity.Property(e => e.UserCardChangeLogIntParamB).HasColumnName("UserCardChangeLog_IntParamB");

                entity.Property(e => e.UserCardChangeLogSyncState).HasColumnName("UserCardChangeLog_SyncState");

                entity.Property(e => e.UserCardChangeLogType).HasColumnName("UserCardChangeLog_Type");

                entity.Property(e => e.UserCardChangeLogUserFavouriteId).HasColumnName("UserCardChangeLog_UserFavouriteID");

                entity.Property(e => e.UserCardChangeLogUserInfoCode).HasColumnName("UserCardChangeLog_UserInfoCode");

                entity.Property(e => e.UserCardChangeLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserCardChangeLog_VarParamA");

                entity.Property(e => e.UserCardChangeLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserCardChangeLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUsercardlog1>(entity =>
            {
                entity.HasKey(e => e.UserCardLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usercardlog1");

                entity.HasIndex(e => new { e.UserCardLogUserInfoCode, e.UserCardLogUserFavouriteId, e.UserCardLogProjectCode }, "Index");

                entity.Property(e => e.UserCardLogId).HasColumnName("UserCardLog_ID");

                entity.Property(e => e.UserCardLogCardType).HasColumnName("UserCardLog_CardType");

                entity.Property(e => e.UserCardLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardLog_Date");

                entity.Property(e => e.UserCardLogFloatParamA).HasColumnName("UserCardLog_FloatParamA");

                entity.Property(e => e.UserCardLogFloatParamB).HasColumnName("UserCardLog_FloatParamB");

                entity.Property(e => e.UserCardLogFtpdataId).HasColumnName("UserCardLog_FTPData_ID");

                entity.Property(e => e.UserCardLogIntParamA).HasColumnName("UserCardLog_IntParamA");

                entity.Property(e => e.UserCardLogIntParamB).HasColumnName("UserCardLog_IntParamB");

                entity.Property(e => e.UserCardLogProjectCode).HasColumnName("UserCardLog_ProjectCode");

                entity.Property(e => e.UserCardLogState).HasColumnName("UserCardLog_State");

                entity.Property(e => e.UserCardLogSyncState).HasColumnName("UserCardLog_SyncState");

                entity.Property(e => e.UserCardLogUsedAmount).HasColumnName("UserCardLog_UsedAmount");

                entity.Property(e => e.UserCardLogUsedCount).HasColumnName("UserCardLog_UsedCount");

                entity.Property(e => e.UserCardLogUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardLog_UsedDate");

                entity.Property(e => e.UserCardLogUsedType).HasColumnName("UserCardLog_UsedType");

                entity.Property(e => e.UserCardLogUserFavouriteId).HasColumnName("UserCardLog_UserFavouriteID");

                entity.Property(e => e.UserCardLogUserInfoCode).HasColumnName("UserCardLog_UserInfoCode");

                entity.Property(e => e.UserCardLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserCardLog_VarParamA");

                entity.Property(e => e.UserCardLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserCardLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUsercardlog2>(entity =>
            {
                entity.HasKey(e => e.UserCardLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usercardlog2");

                entity.HasIndex(e => new { e.UserCardLogUserInfoCode, e.UserCardLogUserFavouriteId, e.UserCardLogProjectCode }, "Index");

                entity.Property(e => e.UserCardLogId).HasColumnName("UserCardLog_ID");

                entity.Property(e => e.UserCardLogCardType).HasColumnName("UserCardLog_CardType");

                entity.Property(e => e.UserCardLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardLog_Date");

                entity.Property(e => e.UserCardLogFloatParamA).HasColumnName("UserCardLog_FloatParamA");

                entity.Property(e => e.UserCardLogFloatParamB).HasColumnName("UserCardLog_FloatParamB");

                entity.Property(e => e.UserCardLogFtpdataId).HasColumnName("UserCardLog_FTPData_ID");

                entity.Property(e => e.UserCardLogIntParamA).HasColumnName("UserCardLog_IntParamA");

                entity.Property(e => e.UserCardLogIntParamB).HasColumnName("UserCardLog_IntParamB");

                entity.Property(e => e.UserCardLogProjectCode).HasColumnName("UserCardLog_ProjectCode");

                entity.Property(e => e.UserCardLogState).HasColumnName("UserCardLog_State");

                entity.Property(e => e.UserCardLogSyncState).HasColumnName("UserCardLog_SyncState");

                entity.Property(e => e.UserCardLogUsedAmount).HasColumnName("UserCardLog_UsedAmount");

                entity.Property(e => e.UserCardLogUsedCount).HasColumnName("UserCardLog_UsedCount");

                entity.Property(e => e.UserCardLogUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardLog_UsedDate");

                entity.Property(e => e.UserCardLogUsedType).HasColumnName("UserCardLog_UsedType");

                entity.Property(e => e.UserCardLogUserFavouriteId).HasColumnName("UserCardLog_UserFavouriteID");

                entity.Property(e => e.UserCardLogUserInfoCode).HasColumnName("UserCardLog_UserInfoCode");

                entity.Property(e => e.UserCardLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserCardLog_VarParamA");

                entity.Property(e => e.UserCardLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserCardLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUsercardlog3>(entity =>
            {
                entity.HasKey(e => e.UserCardLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usercardlog3");

                entity.HasIndex(e => new { e.UserCardLogUserInfoCode, e.UserCardLogProjectCode, e.UserCardLogUserFavouriteId }, "Index");

                entity.Property(e => e.UserCardLogId).HasColumnName("UserCardLog_ID");

                entity.Property(e => e.UserCardLogCardType).HasColumnName("UserCardLog_CardType");

                entity.Property(e => e.UserCardLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardLog_Date");

                entity.Property(e => e.UserCardLogFloatParamA).HasColumnName("UserCardLog_FloatParamA");

                entity.Property(e => e.UserCardLogFloatParamB).HasColumnName("UserCardLog_FloatParamB");

                entity.Property(e => e.UserCardLogFtpdataId).HasColumnName("UserCardLog_FTPData_ID");

                entity.Property(e => e.UserCardLogIntParamA).HasColumnName("UserCardLog_IntParamA");

                entity.Property(e => e.UserCardLogIntParamB).HasColumnName("UserCardLog_IntParamB");

                entity.Property(e => e.UserCardLogProjectCode).HasColumnName("UserCardLog_ProjectCode");

                entity.Property(e => e.UserCardLogState).HasColumnName("UserCardLog_State");

                entity.Property(e => e.UserCardLogSyncState).HasColumnName("UserCardLog_SyncState");

                entity.Property(e => e.UserCardLogUsedAmount).HasColumnName("UserCardLog_UsedAmount");

                entity.Property(e => e.UserCardLogUsedCount).HasColumnName("UserCardLog_UsedCount");

                entity.Property(e => e.UserCardLogUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserCardLog_UsedDate");

                entity.Property(e => e.UserCardLogUsedType).HasColumnName("UserCardLog_UsedType");

                entity.Property(e => e.UserCardLogUserFavouriteId).HasColumnName("UserCardLog_UserFavouriteID");

                entity.Property(e => e.UserCardLogUserInfoCode).HasColumnName("UserCardLog_UserInfoCode");

                entity.Property(e => e.UserCardLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserCardLog_VarParamA");

                entity.Property(e => e.UserCardLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserCardLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUserdefine>(entity =>
            {
                entity.HasKey(e => e.UserDefineId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userdefine");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserDefineChannelId, e.UserDefineCode }, "Index");

                entity.Property(e => e.UserDefineId).HasColumnName("UserDefine_ID");

                entity.Property(e => e.UserDefineAttribute).HasColumnName("UserDefine_Attribute");

                entity.Property(e => e.UserDefineChannelId).HasColumnName("UserDefine_ChannelID");

                entity.Property(e => e.UserDefineCode).HasColumnName("UserDefine_Code");

                entity.Property(e => e.UserDefineFloatParamA).HasColumnName("UserDefine_FloatParamA");

                entity.Property(e => e.UserDefineFloatParamB).HasColumnName("UserDefine_FloatParamB");

                entity.Property(e => e.UserDefineIntParamA).HasColumnName("UserDefine_IntParamA");

                entity.Property(e => e.UserDefineIntParamB).HasColumnName("UserDefine_IntParamB");

                entity.Property(e => e.UserDefineLayNo).HasColumnName("UserDefine_LayNo");

                entity.Property(e => e.UserDefineMemo)
                    .HasColumnType("text")
                    .HasColumnName("UserDefine_Memo");

                entity.Property(e => e.UserDefineName)
                    .HasMaxLength(64)
                    .HasColumnName("UserDefine_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDefinePicUrl1)
                    .HasMaxLength(200)
                    .HasColumnName("UserDefine_PicUrl1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDefinePicUrl2)
                    .HasMaxLength(200)
                    .HasColumnName("UserDefine_PicUrl2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDefinePicUrl3)
                    .HasMaxLength(200)
                    .HasColumnName("UserDefine_PicUrl3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDefinePicUrl4)
                    .HasMaxLength(200)
                    .HasColumnName("UserDefine_PicUrl4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDefinePicUrl5)
                    .HasMaxLength(200)
                    .HasColumnName("UserDefine_PicUrl5")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDefineProdCount).HasColumnName("UserDefine_ProdCount");

                entity.Property(e => e.UserDefineSort).HasColumnName("UserDefine_Sort");

                entity.Property(e => e.UserDefineState).HasColumnName("UserDefine_State");

                entity.Property(e => e.UserDefineSyncState).HasColumnName("UserDefine_SyncState");

                entity.Property(e => e.UserDefineTemplateState).HasColumnName("UserDefine_TemplateState");

                entity.Property(e => e.UserDefineUpUserDefineCode).HasColumnName("UserDefine_UpUserDefineCode");

                entity.Property(e => e.UserDefineVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserDefine_VarParamA");

                entity.Property(e => e.UserDefineVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserDefine_VarParamB");
            });

            modelBuilder.Entity<TbaseUserdevice>(entity =>
            {
                entity.HasKey(e => e.UserDeviceId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userdevice");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserDeviceCode, e.UserDeviceDeviceCode, e.UserDeviceApptoken }, "Index");

                entity.Property(e => e.UserDeviceId).HasColumnName("UserDevice_ID");

                entity.Property(e => e.UserDeviceApptoken)
                    .HasMaxLength(256)
                    .HasColumnName("UserDevice_APPToken")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDeviceCode).HasColumnName("UserDevice_Code");

                entity.Property(e => e.UserDeviceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserDevice_Date");

                entity.Property(e => e.UserDeviceDeviceCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("UserDevice_DeviceCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDeviceFloatParamA).HasColumnName("UserDevice_FloatParamA");

                entity.Property(e => e.UserDeviceFloatParamB).HasColumnName("UserDevice_FloatParamB");

                entity.Property(e => e.UserDeviceIntParamA).HasColumnName("UserDevice_IntParamA");

                entity.Property(e => e.UserDeviceIntParamB).HasColumnName("UserDevice_IntParamB");

                entity.Property(e => e.UserDeviceIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserDevice_IP")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserDeviceState).HasColumnName("UserDevice_State");

                entity.Property(e => e.UserDeviceSyncState).HasColumnName("UserDevice_SyncState");

                entity.Property(e => e.UserDeviceVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserDevice_VarParamA");

                entity.Property(e => e.UserDeviceVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserDevice_VarParamB");
            });

            modelBuilder.Entity<TbaseUserextcode>(entity =>
            {
                entity.HasKey(e => e.UserExtCodeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userextcode");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserExtCodeUserInfoCode, e.UserExtCodePartnerCode, e.UserExtCodeExtCode, e.UserExtCodeCode }, "Index");

                entity.Property(e => e.UserExtCodeId).HasColumnName("UserExtCode_ID");

                entity.Property(e => e.UserExtCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("UserExtCode_Code")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserExtCodeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserExtCode_Date");

                entity.Property(e => e.UserExtCodeExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("UserExtCode_Expiry");

                entity.Property(e => e.UserExtCodeExtCode)
                    .HasMaxLength(100)
                    .HasColumnName("UserExtCode_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserExtCodeFloatParamA).HasColumnName("UserExtCode_FloatParamA");

                entity.Property(e => e.UserExtCodeFloatParamB).HasColumnName("UserExtCode_FloatParamB");

                entity.Property(e => e.UserExtCodeIntParamA).HasColumnName("UserExtCode_IntParamA");

                entity.Property(e => e.UserExtCodeIntParamB).HasColumnName("UserExtCode_IntParamB");

                entity.Property(e => e.UserExtCodePartnerCode).HasColumnName("UserExtCode_PartnerCode");

                entity.Property(e => e.UserExtCodeState).HasColumnName("UserExtCode_State");

                entity.Property(e => e.UserExtCodeSyncState).HasColumnName("UserExtCode_SyncState");

                entity.Property(e => e.UserExtCodeUserInfoCode).HasColumnName("UserExtCode_UserInfoCode");

                entity.Property(e => e.UserExtCodeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserExtCode_VarParamA");

                entity.Property(e => e.UserExtCodeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserExtCode_VarParamB");
            });

            modelBuilder.Entity<TbaseUserfavourite1>(entity =>
            {
                entity.HasKey(e => e.UserFavouriteId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userfavourite1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserFavouriteType, e.UserFavouriteUserInfoCode, e.UserFavouriteTypeCode }, "Index");

                entity.Property(e => e.UserFavouriteId).HasColumnName("UserFavourite_ID");

                entity.Property(e => e.UserFavouriteCountryCode).HasColumnName("UserFavourite_CountryCode");

                entity.Property(e => e.UserFavouriteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserFavourite_Date");

                entity.Property(e => e.UserFavouriteEncryption)
                    .HasMaxLength(500)
                    .HasColumnName("UserFavourite_Encryption")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteFloatParamA).HasColumnName("UserFavourite_FloatParamA");

                entity.Property(e => e.UserFavouriteFloatParamB).HasColumnName("UserFavourite_FloatParamB");

                entity.Property(e => e.UserFavouriteIntParamA).HasColumnName("UserFavourite_IntParamA");

                entity.Property(e => e.UserFavouriteIntParamB).HasColumnName("UserFavourite_IntParamB");

                entity.Property(e => e.UserFavouriteIsDefault).HasColumnName("UserFavourite_IsDefault");

                entity.Property(e => e.UserFavouriteNumber1).HasColumnName("UserFavourite_Number1");

                entity.Property(e => e.UserFavouriteNumber2).HasColumnName("UserFavourite_Number2");

                entity.Property(e => e.UserFavouriteSort).HasColumnName("UserFavourite_Sort");

                entity.Property(e => e.UserFavouriteState).HasColumnName("UserFavourite_State");

                entity.Property(e => e.UserFavouriteSyncState).HasColumnName("UserFavourite_SyncState");

                entity.Property(e => e.UserFavouriteText1)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText2)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText3)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Text3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText4)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Text4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteToken)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteTokenTerm)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_TokenTerm")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteType).HasColumnName("UserFavourite_Type");

                entity.Property(e => e.UserFavouriteTypeCode).HasColumnName("UserFavourite_TypeCode");

                entity.Property(e => e.UserFavouriteUserInfoCode).HasColumnName("UserFavourite_UserInfoCode");

                entity.Property(e => e.UserFavouriteVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserFavourite_VarParamA");

                entity.Property(e => e.UserFavouriteVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserFavourite_VarParamB");
            });

            modelBuilder.Entity<TbaseUserfavourite2>(entity =>
            {
                entity.HasKey(e => e.UserFavouriteId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userfavourite2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserFavouriteType, e.UserFavouriteUserInfoCode, e.UserFavouriteTypeCode }, "Index");

                entity.Property(e => e.UserFavouriteId).HasColumnName("UserFavourite_ID");

                entity.Property(e => e.UserFavouriteCountryCode).HasColumnName("UserFavourite_CountryCode");

                entity.Property(e => e.UserFavouriteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserFavourite_Date");

                entity.Property(e => e.UserFavouriteEncryption)
                    .HasMaxLength(500)
                    .HasColumnName("UserFavourite_Encryption")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteFloatParamA).HasColumnName("UserFavourite_FloatParamA");

                entity.Property(e => e.UserFavouriteFloatParamB).HasColumnName("UserFavourite_FloatParamB");

                entity.Property(e => e.UserFavouriteIntParamA).HasColumnName("UserFavourite_IntParamA");

                entity.Property(e => e.UserFavouriteIntParamB).HasColumnName("UserFavourite_IntParamB");

                entity.Property(e => e.UserFavouriteIsDefault).HasColumnName("UserFavourite_IsDefault");

                entity.Property(e => e.UserFavouriteNumber1).HasColumnName("UserFavourite_Number1");

                entity.Property(e => e.UserFavouriteNumber2).HasColumnName("UserFavourite_Number2");

                entity.Property(e => e.UserFavouriteSort).HasColumnName("UserFavourite_Sort");

                entity.Property(e => e.UserFavouriteState).HasColumnName("UserFavourite_State");

                entity.Property(e => e.UserFavouriteSyncState).HasColumnName("UserFavourite_SyncState");

                entity.Property(e => e.UserFavouriteText1)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText2)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText3)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Text3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText4)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Text4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteToken)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteTokenTerm)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_TokenTerm")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteType).HasColumnName("UserFavourite_Type");

                entity.Property(e => e.UserFavouriteTypeCode).HasColumnName("UserFavourite_TypeCode");

                entity.Property(e => e.UserFavouriteUserInfoCode).HasColumnName("UserFavourite_UserInfoCode");

                entity.Property(e => e.UserFavouriteVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserFavourite_VarParamA");

                entity.Property(e => e.UserFavouriteVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserFavourite_VarParamB");
            });

            modelBuilder.Entity<TbaseUserfavourite3>(entity =>
            {
                entity.HasKey(e => e.UserFavouriteId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userfavourite3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserFavouriteType, e.UserFavouriteUserInfoCode, e.UserFavouriteTypeCode }, "Index");

                entity.Property(e => e.UserFavouriteId).HasColumnName("UserFavourite_ID");

                entity.Property(e => e.UserFavouriteCountryCode).HasColumnName("UserFavourite_CountryCode");

                entity.Property(e => e.UserFavouriteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserFavourite_Date");

                entity.Property(e => e.UserFavouriteEncryption)
                    .HasMaxLength(500)
                    .HasColumnName("UserFavourite_Encryption")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteFloatParamA).HasColumnName("UserFavourite_FloatParamA");

                entity.Property(e => e.UserFavouriteFloatParamB).HasColumnName("UserFavourite_FloatParamB");

                entity.Property(e => e.UserFavouriteIntParamA).HasColumnName("UserFavourite_IntParamA");

                entity.Property(e => e.UserFavouriteIntParamB).HasColumnName("UserFavourite_IntParamB");

                entity.Property(e => e.UserFavouriteIsDefault).HasColumnName("UserFavourite_IsDefault");

                entity.Property(e => e.UserFavouriteNumber1).HasColumnName("UserFavourite_Number1");

                entity.Property(e => e.UserFavouriteNumber2).HasColumnName("UserFavourite_Number2");

                entity.Property(e => e.UserFavouriteSort).HasColumnName("UserFavourite_Sort");

                entity.Property(e => e.UserFavouriteState).HasColumnName("UserFavourite_State");

                entity.Property(e => e.UserFavouriteSyncState).HasColumnName("UserFavourite_SyncState");

                entity.Property(e => e.UserFavouriteText1)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText2)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText3)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Text3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteText4)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Text4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteToken)
                    .HasMaxLength(200)
                    .HasColumnName("UserFavourite_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteTokenTerm)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_TokenTerm")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteType).HasColumnName("UserFavourite_Type");

                entity.Property(e => e.UserFavouriteTypeCode).HasColumnName("UserFavourite_TypeCode");

                entity.Property(e => e.UserFavouriteUserInfoCode).HasColumnName("UserFavourite_UserInfoCode");

                entity.Property(e => e.UserFavouriteVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserFavourite_VarParamA");

                entity.Property(e => e.UserFavouriteVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserFavourite_VarParamB");
            });

            modelBuilder.Entity<TbaseUserinfo>(entity =>
            {
                entity.HasKey(e => e.UserInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userinfo");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserInfoCode, e.UserInfoAccount, e.UserInfoType, e.UserInfoEcstoreCode, e.UserInfoName }, "Index");

                entity.Property(e => e.UserInfoId).HasColumnName("UserInfo_ID");

                entity.Property(e => e.UserInfoAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserInfo_Account")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserInfoAccountCty).HasColumnName("UserInfo_AccountCTY");

                entity.Property(e => e.UserInfoCode).HasColumnName("UserInfo_Code");

                entity.Property(e => e.UserInfoCompanyCode).HasColumnName("UserInfo_CompanyCode");

                entity.Property(e => e.UserInfoCountryCode).HasColumnName("UserInfo_CountryCode");

                entity.Property(e => e.UserInfoEcstoreCode).HasColumnName("UserInfo_ECStoreCode");

                entity.Property(e => e.UserInfoExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserInfo_ExpireDate");

                entity.Property(e => e.UserInfoExtCode)
                    .HasMaxLength(36)
                    .HasColumnName("UserInfo_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserInfoFloatParamA).HasColumnName("UserInfo_FloatParamA");

                entity.Property(e => e.UserInfoFloatParamB).HasColumnName("UserInfo_FloatParamB");

                entity.Property(e => e.UserInfoGroupNo).HasColumnName("UserInfo_GroupNo");

                entity.Property(e => e.UserInfoInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserInfo_InsertDate");

                entity.Property(e => e.UserInfoIntParamA).HasColumnName("UserInfo_IntParamA");

                entity.Property(e => e.UserInfoIntParamB).HasColumnName("UserInfo_IntParamB");

                entity.Property(e => e.UserInfoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserInfo_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserInfoPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("UserInfo_Password")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserInfoPoint).HasColumnName("UserInfo_Point");

                entity.Property(e => e.UserInfoRegisterDevice).HasColumnName("UserInfo_RegisterDevice");

                entity.Property(e => e.UserInfoState).HasColumnName("UserInfo_State");

                entity.Property(e => e.UserInfoSyncState).HasColumnName("UserInfo_SyncState");

                entity.Property(e => e.UserInfoType).HasColumnName("UserInfo_Type");

                entity.Property(e => e.UserInfoUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserInfo_UpdateDate");

                entity.Property(e => e.UserInfoUuid)
                    .HasMaxLength(20)
                    .HasColumnName("UserInfo_UUID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserInfo_VarParamA");

                entity.Property(e => e.UserInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserInfo_VarParamB");

                entity.Property(e => e.UserInfoVirtualPoint).HasColumnName("UserInfo_VirtualPoint");
            });

            modelBuilder.Entity<TbaseUserlevelinfo>(entity =>
            {
                entity.HasKey(e => e.UserLevelInfoId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userlevelinfo");

                entity.HasIndex(e => new { e.UserLevelInfoLevelCode, e.UserLevelInfoUserInfoCode }, "Index");

                entity.Property(e => e.UserLevelInfoId).HasColumnName("UserLevelInfo_ID");

                entity.Property(e => e.UserLevelInfoDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserLevelInfo_Date");

                entity.Property(e => e.UserLevelInfoFloatParamA).HasColumnName("UserLevelInfo_FloatParamA");

                entity.Property(e => e.UserLevelInfoFloatParamB).HasColumnName("UserLevelInfo_FloatParamB");

                entity.Property(e => e.UserLevelInfoIntParamA).HasColumnName("UserLevelInfo_IntParamA");

                entity.Property(e => e.UserLevelInfoIntParamB).HasColumnName("UserLevelInfo_IntParamB");

                entity.Property(e => e.UserLevelInfoLevelCode).HasColumnName("UserLevelInfo_LevelCode");

                entity.Property(e => e.UserLevelInfoState).HasColumnName("UserLevelInfo_State");

                entity.Property(e => e.UserLevelInfoSyncState).HasColumnName("UserLevelInfo_SyncState");

                entity.Property(e => e.UserLevelInfoUserInfoCode).HasColumnName("UserLevelInfo_UserInfoCode");

                entity.Property(e => e.UserLevelInfoVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserLevelInfo_VarParamA");

                entity.Property(e => e.UserLevelInfoVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserLevelInfo_VarParamB");
            });

            modelBuilder.Entity<TbaseUsermission1>(entity =>
            {
                entity.HasKey(e => e.UserMissionId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usermission1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserMissionMissionCode, e.UserMissionUserInfoCode }, "Index");

                entity.Property(e => e.UserMissionId).HasColumnName("UserMission_ID");

                entity.Property(e => e.UserMissionAmountCount).HasColumnName("UserMission_AmountCount");

                entity.Property(e => e.UserMissionAmountPoint).HasColumnName("UserMission_AmountPoint");

                entity.Property(e => e.UserMissionCompleteCount).HasColumnName("UserMission_CompleteCount");

                entity.Property(e => e.UserMissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_Date");

                entity.Property(e => e.UserMissionFloatParamA).HasColumnName("UserMission_FloatParamA");

                entity.Property(e => e.UserMissionFloatParamB).HasColumnName("UserMission_FloatParamB");

                entity.Property(e => e.UserMissionFreqCount).HasColumnName("UserMission_FreqCount");

                entity.Property(e => e.UserMissionIntParamA).HasColumnName("UserMission_IntParamA");

                entity.Property(e => e.UserMissionIntParamB).HasColumnName("UserMission_IntParamB");

                entity.Property(e => e.UserMissionIsReleased).HasColumnName("UserMission_IsReleased");

                entity.Property(e => e.UserMissionMissionCode).HasColumnName("UserMission_MissionCode");

                entity.Property(e => e.UserMissionRelLimtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_RelLimtDate");

                entity.Property(e => e.UserMissionReleasedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_ReleasedDate");

                entity.Property(e => e.UserMissionState).HasColumnName("UserMission_State");

                entity.Property(e => e.UserMissionSyncState).HasColumnName("UserMission_SyncState");

                entity.Property(e => e.UserMissionUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_UpdateDate");

                entity.Property(e => e.UserMissionUserInfoCode).HasColumnName("UserMission_UserInfoCode");

                entity.Property(e => e.UserMissionVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserMission_VarParamA");

                entity.Property(e => e.UserMissionVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserMission_VarParamB");
            });

            modelBuilder.Entity<TbaseUsermission2>(entity =>
            {
                entity.HasKey(e => e.UserMissionId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usermission2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserMissionUserInfoCode, e.UserMissionMissionCode }, "Index");

                entity.Property(e => e.UserMissionId).HasColumnName("UserMission_ID");

                entity.Property(e => e.UserMissionAmountCount).HasColumnName("UserMission_AmountCount");

                entity.Property(e => e.UserMissionAmountPoint).HasColumnName("UserMission_AmountPoint");

                entity.Property(e => e.UserMissionCompleteCount).HasColumnName("UserMission_CompleteCount");

                entity.Property(e => e.UserMissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_Date");

                entity.Property(e => e.UserMissionFloatParamA).HasColumnName("UserMission_FloatParamA");

                entity.Property(e => e.UserMissionFloatParamB).HasColumnName("UserMission_FloatParamB");

                entity.Property(e => e.UserMissionFreqCount).HasColumnName("UserMission_FreqCount");

                entity.Property(e => e.UserMissionIntParamA).HasColumnName("UserMission_IntParamA");

                entity.Property(e => e.UserMissionIntParamB).HasColumnName("UserMission_IntParamB");

                entity.Property(e => e.UserMissionIsReleased).HasColumnName("UserMission_IsReleased");

                entity.Property(e => e.UserMissionMissionCode).HasColumnName("UserMission_MissionCode");

                entity.Property(e => e.UserMissionRelLimtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_RelLimtDate");

                entity.Property(e => e.UserMissionReleasedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_ReleasedDate");

                entity.Property(e => e.UserMissionState).HasColumnName("UserMission_State");

                entity.Property(e => e.UserMissionSyncState).HasColumnName("UserMission_SyncState");

                entity.Property(e => e.UserMissionUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_UpdateDate");

                entity.Property(e => e.UserMissionUserInfoCode).HasColumnName("UserMission_UserInfoCode");

                entity.Property(e => e.UserMissionVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserMission_VarParamA");

                entity.Property(e => e.UserMissionVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserMission_VarParamB");
            });

            modelBuilder.Entity<TbaseUsermission3>(entity =>
            {
                entity.HasKey(e => e.UserMissionId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_usermission3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserMissionMissionCode, e.UserMissionUserInfoCode }, "Index");

                entity.Property(e => e.UserMissionId).HasColumnName("UserMission_ID");

                entity.Property(e => e.UserMissionAmountCount).HasColumnName("UserMission_AmountCount");

                entity.Property(e => e.UserMissionAmountPoint).HasColumnName("UserMission_AmountPoint");

                entity.Property(e => e.UserMissionCompleteCount).HasColumnName("UserMission_CompleteCount");

                entity.Property(e => e.UserMissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_Date");

                entity.Property(e => e.UserMissionFloatParamA).HasColumnName("UserMission_FloatParamA");

                entity.Property(e => e.UserMissionFloatParamB).HasColumnName("UserMission_FloatParamB");

                entity.Property(e => e.UserMissionFreqCount).HasColumnName("UserMission_FreqCount");

                entity.Property(e => e.UserMissionIntParamA).HasColumnName("UserMission_IntParamA");

                entity.Property(e => e.UserMissionIntParamB).HasColumnName("UserMission_IntParamB");

                entity.Property(e => e.UserMissionIsReleased).HasColumnName("UserMission_IsReleased");

                entity.Property(e => e.UserMissionMissionCode).HasColumnName("UserMission_MissionCode");

                entity.Property(e => e.UserMissionRelLimtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_RelLimtDate");

                entity.Property(e => e.UserMissionReleasedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_ReleasedDate");

                entity.Property(e => e.UserMissionState).HasColumnName("UserMission_State");

                entity.Property(e => e.UserMissionSyncState).HasColumnName("UserMission_SyncState");

                entity.Property(e => e.UserMissionUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_UpdateDate");

                entity.Property(e => e.UserMissionUserInfoCode).HasColumnName("UserMission_UserInfoCode");

                entity.Property(e => e.UserMissionVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserMission_VarParamA");

                entity.Property(e => e.UserMissionVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserMission_VarParamB");
            });

            modelBuilder.Entity<TbaseUserpoint1>(entity =>
            {
                entity.HasKey(e => e.UserPointId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userpoint1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.UserPointUserInfoCode, "Index");

                entity.Property(e => e.UserPointId).HasColumnName("UserPoint_ID");

                entity.Property(e => e.UserPointActiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_ActiveDate");

                entity.Property(e => e.UserPointAddQuantity).HasColumnName("UserPoint_AddQuantity");

                entity.Property(e => e.UserPointAmountQuantity).HasColumnName("UserPoint_AmountQuantity");

                entity.Property(e => e.UserPointDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_Date");

                entity.Property(e => e.UserPointDeductQuantity).HasColumnName("UserPoint_DeductQuantity");

                entity.Property(e => e.UserPointFloatParamA).HasColumnName("UserPoint_FloatParamA");

                entity.Property(e => e.UserPointFloatParamB).HasColumnName("UserPoint_FloatParamB");

                entity.Property(e => e.UserPointIntParamA).HasColumnName("UserPoint_IntParamA");

                entity.Property(e => e.UserPointIntParamB).HasColumnName("UserPoint_IntParamB");

                entity.Property(e => e.UserPointLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_LimitDate");

                entity.Property(e => e.UserPointRegQuantity).HasColumnName("UserPoint_RegQuantity");

                entity.Property(e => e.UserPointState).HasColumnName("UserPoint_State");

                entity.Property(e => e.UserPointSubText)
                    .HasMaxLength(500)
                    .HasColumnName("UserPoint_SubText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserPointText)
                    .HasMaxLength(500)
                    .HasColumnName("UserPoint_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserPointType).HasColumnName("UserPoint_Type");

                entity.Property(e => e.UserPointUserInfoCode).HasColumnName("UserPoint_UserInfoCode");

                entity.Property(e => e.UserPointVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserPoint_VarParamA");

                entity.Property(e => e.UserPointVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserPoint_VarParamB");
            });

            modelBuilder.Entity<TbaseUserpoint2>(entity =>
            {
                entity.HasKey(e => e.UserPointId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userpoint2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.UserPointUserInfoCode, "Index");

                entity.Property(e => e.UserPointId).HasColumnName("UserPoint_ID");

                entity.Property(e => e.UserPointActiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_ActiveDate");

                entity.Property(e => e.UserPointAddQuantity).HasColumnName("UserPoint_AddQuantity");

                entity.Property(e => e.UserPointAmountQuantity).HasColumnName("UserPoint_AmountQuantity");

                entity.Property(e => e.UserPointDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_Date");

                entity.Property(e => e.UserPointDeductQuantity).HasColumnName("UserPoint_DeductQuantity");

                entity.Property(e => e.UserPointFloatParamA).HasColumnName("UserPoint_FloatParamA");

                entity.Property(e => e.UserPointFloatParamB).HasColumnName("UserPoint_FloatParamB");

                entity.Property(e => e.UserPointIntParamA).HasColumnName("UserPoint_IntParamA");

                entity.Property(e => e.UserPointIntParamB).HasColumnName("UserPoint_IntParamB");

                entity.Property(e => e.UserPointLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_LimitDate");

                entity.Property(e => e.UserPointRegQuantity).HasColumnName("UserPoint_RegQuantity");

                entity.Property(e => e.UserPointState).HasColumnName("UserPoint_State");

                entity.Property(e => e.UserPointSubText)
                    .HasMaxLength(500)
                    .HasColumnName("UserPoint_SubText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserPointText)
                    .HasMaxLength(500)
                    .HasColumnName("UserPoint_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserPointType).HasColumnName("UserPoint_Type");

                entity.Property(e => e.UserPointUserInfoCode).HasColumnName("UserPoint_UserInfoCode");

                entity.Property(e => e.UserPointVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserPoint_VarParamA");

                entity.Property(e => e.UserPointVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserPoint_VarParamB");
            });

            modelBuilder.Entity<TbaseUserpoint3>(entity =>
            {
                entity.HasKey(e => e.UserPointId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userpoint3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.UserPointUserInfoCode, "Index");

                entity.Property(e => e.UserPointId).HasColumnName("UserPoint_ID");

                entity.Property(e => e.UserPointActiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_ActiveDate");

                entity.Property(e => e.UserPointAddQuantity).HasColumnName("UserPoint_AddQuantity");

                entity.Property(e => e.UserPointAmountQuantity).HasColumnName("UserPoint_AmountQuantity");

                entity.Property(e => e.UserPointDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_Date");

                entity.Property(e => e.UserPointDeductQuantity).HasColumnName("UserPoint_DeductQuantity");

                entity.Property(e => e.UserPointFloatParamA).HasColumnName("UserPoint_FloatParamA");

                entity.Property(e => e.UserPointFloatParamB).HasColumnName("UserPoint_FloatParamB");

                entity.Property(e => e.UserPointIntParamA).HasColumnName("UserPoint_IntParamA");

                entity.Property(e => e.UserPointIntParamB).HasColumnName("UserPoint_IntParamB");

                entity.Property(e => e.UserPointLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserPoint_LimitDate");

                entity.Property(e => e.UserPointRegQuantity).HasColumnName("UserPoint_RegQuantity");

                entity.Property(e => e.UserPointState).HasColumnName("UserPoint_State");

                entity.Property(e => e.UserPointSubText)
                    .HasMaxLength(500)
                    .HasColumnName("UserPoint_SubText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserPointText)
                    .HasMaxLength(500)
                    .HasColumnName("UserPoint_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserPointType).HasColumnName("UserPoint_Type");

                entity.Property(e => e.UserPointUserInfoCode).HasColumnName("UserPoint_UserInfoCode");

                entity.Property(e => e.UserPointVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserPoint_VarParamA");

                entity.Property(e => e.UserPointVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserPoint_VarParamB");
            });

            modelBuilder.Entity<TbaseUserprofile>(entity =>
            {
                entity.HasKey(e => e.UserProfileId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userprofile");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserProfileUserInfoCode, e.UserProfileCompanyCode, e.UserProfileName, e.UserProfileEmail }, "Index");

                entity.Property(e => e.UserProfileId).HasColumnName("UserProfile_ID");

                entity.Property(e => e.UserProfileAddress)
                    .HasMaxLength(200)
                    .HasColumnName("UserProfile_Address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileBirthday)
                    .HasColumnType("datetime")
                    .HasColumnName("UserProfile_Birthday");

                entity.Property(e => e.UserProfileBloodType).HasColumnName("UserProfile_BloodType");

                entity.Property(e => e.UserProfileCheckHealthDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserProfile_CheckHealthDate");

                entity.Property(e => e.UserProfileCity).HasColumnName("UserProfile_City");

                entity.Property(e => e.UserProfileCityArea).HasColumnName("UserProfile_CityArea");

                entity.Property(e => e.UserProfileCompanyCode).HasColumnName("UserProfile_CompanyCode");

                entity.Property(e => e.UserProfileCountry).HasColumnName("UserProfile_Country");

                entity.Property(e => e.UserProfileDepart).HasColumnName("UserProfile_Depart");

                entity.Property(e => e.UserProfileDriveType).HasColumnName("UserProfile_DriveType");

                entity.Property(e => e.UserProfileDutyAgent).HasColumnName("UserProfile_DutyAgent");

                entity.Property(e => e.UserProfileEmail)
                    .HasMaxLength(50)
                    .HasColumnName("UserProfile_Email")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileFloatParamA).HasColumnName("UserProfile_FloatParamA");

                entity.Property(e => e.UserProfileFloatParamB).HasColumnName("UserProfile_FloatParamB");

                entity.Property(e => e.UserProfileHealthState)
                    .HasMaxLength(100)
                    .HasColumnName("UserProfile_HealthState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileHeight).HasColumnName("UserProfile_Height");

                entity.Property(e => e.UserProfileHiredType).HasColumnName("UserProfile_HiredType");

                entity.Property(e => e.UserProfileIdno)
                    .HasMaxLength(30)
                    .HasColumnName("UserProfile_IDNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileInnerDegree).HasColumnName("UserProfile_InnerDegree");

                entity.Property(e => e.UserProfileInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserProfile_InsertDate");

                entity.Property(e => e.UserProfileIntParamA).HasColumnName("UserProfile_IntParamA");

                entity.Property(e => e.UserProfileIntParamB).HasColumnName("UserProfile_IntParamB");

                entity.Property(e => e.UserProfileLinkRelationship)
                    .HasMaxLength(20)
                    .HasColumnName("UserProfile_LinkRelationship")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileLinkTel)
                    .HasMaxLength(20)
                    .HasColumnName("UserProfile_LinkTel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileLinkman)
                    .HasMaxLength(30)
                    .HasColumnName("UserProfile_Linkman")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileLocalAddress)
                    .HasMaxLength(100)
                    .HasColumnName("UserProfile_LocalAddress")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileLocalCity).HasColumnName("UserProfile_LocalCity");

                entity.Property(e => e.UserProfileLocalCityArea).HasColumnName("UserProfile_LocalCityArea");

                entity.Property(e => e.UserProfileLocalCountry).HasColumnName("UserProfile_LocalCountry");

                entity.Property(e => e.UserProfileLocalTel)
                    .HasMaxLength(20)
                    .HasColumnName("UserProfile_LocalTel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileMarriage).HasColumnName("UserProfile_Marriage");

                entity.Property(e => e.UserProfileMobile)
                    .HasMaxLength(20)
                    .HasColumnName("UserProfile_Mobile")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileName)
                    .HasMaxLength(30)
                    .HasColumnName("UserProfile_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileOutDegree).HasColumnName("UserProfile_OutDegree");

                entity.Property(e => e.UserProfileSex).HasColumnName("UserProfile_Sex");

                entity.Property(e => e.UserProfileState).HasColumnName("UserProfile_State");

                entity.Property(e => e.UserProfileSupervisor).HasColumnName("UserProfile_Supervisor");

                entity.Property(e => e.UserProfileSyncState).HasColumnName("UserProfile_SyncState");

                entity.Property(e => e.UserProfileTel)
                    .HasMaxLength(20)
                    .HasColumnName("UserProfile_Tel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserProfileUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserProfile_UpdateDate");

                entity.Property(e => e.UserProfileUserInfoCode).HasColumnName("UserProfile_UserInfoCode");

                entity.Property(e => e.UserProfileVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserProfile_VarParamA");

                entity.Property(e => e.UserProfileVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserProfile_VarParamB");

                entity.Property(e => e.UserProfileWeight).HasColumnName("UserProfile_Weight");
            });

            modelBuilder.Entity<TbaseUserrole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userrole");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserRoleUserInfoCode, e.UserRoleRoleInfoCode }, "Index");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRole_ID");

                entity.Property(e => e.UserRoleFloatParamA).HasColumnName("UserRole_FloatParamA");

                entity.Property(e => e.UserRoleFloatParamB).HasColumnName("UserRole_FloatParamB");

                entity.Property(e => e.UserRoleIntParamA).HasColumnName("UserRole_IntParamA");

                entity.Property(e => e.UserRoleIntParamB).HasColumnName("UserRole_IntParamB");

                entity.Property(e => e.UserRoleRoleInfoCode).HasColumnName("UserRole_RoleInfoCode");

                entity.Property(e => e.UserRoleSyncState).HasColumnName("UserRole_SyncState");

                entity.Property(e => e.UserRoleUserInfoCode).HasColumnName("UserRole_UserInfoCode");

                entity.Property(e => e.UserRoleVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserRole_VarParamA");

                entity.Property(e => e.UserRoleVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserRole_VarParamB");
            });

            modelBuilder.Entity<TbaseUserspree1>(entity =>
            {
                entity.HasKey(e => e.UserSpreeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userspree1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserSpreeUserInfoCode, e.UserSpreeVoucherCode, e.UserSpreeSpreeCode, e.UserSpreeReceiveDate }, "Index");

                entity.Property(e => e.UserSpreeId).HasColumnName("UserSpree_ID");

                entity.Property(e => e.UserSpreeFloatParamA).HasColumnName("UserSpree_FloatParamA");

                entity.Property(e => e.UserSpreeFloatParamB).HasColumnName("UserSpree_FloatParamB");

                entity.Property(e => e.UserSpreeIntParamA).HasColumnName("UserSpree_IntParamA");

                entity.Property(e => e.UserSpreeIntParamB).HasColumnName("UserSpree_IntParamB");

                entity.Property(e => e.UserSpreeReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserSpree_ReceiveDate");

                entity.Property(e => e.UserSpreeSpreeCode).HasColumnName("UserSpree_SpreeCode");

                entity.Property(e => e.UserSpreeState).HasColumnName("UserSpree_State");

                entity.Property(e => e.UserSpreeSyncState).HasColumnName("UserSpree_SyncState");

                entity.Property(e => e.UserSpreeUserInfoCode).HasColumnName("UserSpree_UserInfoCode");

                entity.Property(e => e.UserSpreeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserSpree_VarParamA");

                entity.Property(e => e.UserSpreeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserSpree_VarParamB");

                entity.Property(e => e.UserSpreeVoucherCode).HasColumnName("UserSpree_VoucherCode");
            });

            modelBuilder.Entity<TbaseUserspree2>(entity =>
            {
                entity.HasKey(e => e.UserSpreeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userspree2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserSpreeUserInfoCode, e.UserSpreeSpreeCode, e.UserSpreeVoucherCode, e.UserSpreeReceiveDate }, "Index");

                entity.Property(e => e.UserSpreeId).HasColumnName("UserSpree_ID");

                entity.Property(e => e.UserSpreeFloatParamA).HasColumnName("UserSpree_FloatParamA");

                entity.Property(e => e.UserSpreeFloatParamB).HasColumnName("UserSpree_FloatParamB");

                entity.Property(e => e.UserSpreeIntParamA).HasColumnName("UserSpree_IntParamA");

                entity.Property(e => e.UserSpreeIntParamB).HasColumnName("UserSpree_IntParamB");

                entity.Property(e => e.UserSpreeReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserSpree_ReceiveDate");

                entity.Property(e => e.UserSpreeSpreeCode).HasColumnName("UserSpree_SpreeCode");

                entity.Property(e => e.UserSpreeState).HasColumnName("UserSpree_State");

                entity.Property(e => e.UserSpreeSyncState).HasColumnName("UserSpree_SyncState");

                entity.Property(e => e.UserSpreeUserInfoCode).HasColumnName("UserSpree_UserInfoCode");

                entity.Property(e => e.UserSpreeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserSpree_VarParamA");

                entity.Property(e => e.UserSpreeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserSpree_VarParamB");

                entity.Property(e => e.UserSpreeVoucherCode).HasColumnName("UserSpree_VoucherCode");
            });

            modelBuilder.Entity<TbaseUserspree3>(entity =>
            {
                entity.HasKey(e => e.UserSpreeId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userspree3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserSpreeUserInfoCode, e.UserSpreeVoucherCode, e.UserSpreeSpreeCode, e.UserSpreeReceiveDate }, "Index");

                entity.Property(e => e.UserSpreeId).HasColumnName("UserSpree_ID");

                entity.Property(e => e.UserSpreeFloatParamA).HasColumnName("UserSpree_FloatParamA");

                entity.Property(e => e.UserSpreeFloatParamB).HasColumnName("UserSpree_FloatParamB");

                entity.Property(e => e.UserSpreeIntParamA).HasColumnName("UserSpree_IntParamA");

                entity.Property(e => e.UserSpreeIntParamB).HasColumnName("UserSpree_IntParamB");

                entity.Property(e => e.UserSpreeReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserSpree_ReceiveDate");

                entity.Property(e => e.UserSpreeSpreeCode).HasColumnName("UserSpree_SpreeCode");

                entity.Property(e => e.UserSpreeState).HasColumnName("UserSpree_State");

                entity.Property(e => e.UserSpreeSyncState).HasColumnName("UserSpree_SyncState");

                entity.Property(e => e.UserSpreeUserInfoCode).HasColumnName("UserSpree_UserInfoCode");

                entity.Property(e => e.UserSpreeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserSpree_VarParamA");

                entity.Property(e => e.UserSpreeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserSpree_VarParamB");

                entity.Property(e => e.UserSpreeVoucherCode).HasColumnName("UserSpree_VoucherCode");
            });

            modelBuilder.Entity<TbaseUserthird>(entity =>
            {
                entity.HasKey(e => e.UserThirdId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userthird");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserThirdUserInfoCode, e.UserThirdToken }, "Index");

                entity.Property(e => e.UserThirdId).HasColumnName("UserThird_ID");

                entity.Property(e => e.UserThirdFloatParamA).HasColumnName("UserThird_FloatParamA");

                entity.Property(e => e.UserThirdFloatParamB).HasColumnName("UserThird_FloatParamB");

                entity.Property(e => e.UserThirdIntParamA).HasColumnName("UserThird_IntParamA");

                entity.Property(e => e.UserThirdIntParamB).HasColumnName("UserThird_IntParamB");

                entity.Property(e => e.UserThirdJsonData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("UserThird_JsonData");

                entity.Property(e => e.UserThirdMode).HasColumnName("UserThird_Mode");

                entity.Property(e => e.UserThirdState).HasColumnName("UserThird_State");

                entity.Property(e => e.UserThirdSyncState).HasColumnName("UserThird_SyncState");

                entity.Property(e => e.UserThirdToken)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("UserThird_Token")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserThirdUserInfoCode).HasColumnName("UserThird_UserInfoCode");

                entity.Property(e => e.UserThirdVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserThird_VarParamA");

                entity.Property(e => e.UserThirdVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserThird_VarParamB");
            });

            modelBuilder.Entity<TbaseUserticket1>(entity =>
            {
                entity.HasKey(e => e.UserTicketId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userticket1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserTicketUserInfoCode, e.UserTicketCode, e.UserTicketUsedState }, "Index");

                entity.Property(e => e.UserTicketId).HasColumnName("UserTicket_ID");

                entity.Property(e => e.UserTicketBuyModel)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_BuyModel");

                entity.Property(e => e.UserTicketCode).HasColumnName("UserTicket_Code");

                entity.Property(e => e.UserTicketDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_Date");

                entity.Property(e => e.UserTicketExtCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserTicket_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketFloatParamA).HasColumnName("UserTicket_FloatParamA");

                entity.Property(e => e.UserTicketFloatParamB).HasColumnName("UserTicket_FloatParamB");

                entity.Property(e => e.UserTicketIntParamA).HasColumnName("UserTicket_IntParamA");

                entity.Property(e => e.UserTicketIntParamB).HasColumnName("UserTicket_IntParamB");

                entity.Property(e => e.UserTicketLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_LimitDate");

                entity.Property(e => e.UserTicketOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_OpenDate");

                entity.Property(e => e.UserTicketProdCode).HasColumnName("UserTicket_ProdCode");

                entity.Property(e => e.UserTicketQrcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_QRCode");

                entity.Property(e => e.UserTicketRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_RefundDate");

                entity.Property(e => e.UserTicketRefundFee).HasColumnName("UserTicket_RefundFee");

                entity.Property(e => e.UserTicketRefundModel)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_RefundModel");

                entity.Property(e => e.UserTicketState).HasColumnName("UserTicket_State");

                entity.Property(e => e.UserTicketSyncState).HasColumnName("UserTicket_SyncState");

                entity.Property(e => e.UserTicketUniqueId)
                    .HasMaxLength(50)
                    .HasColumnName("UserTicket_UniqueID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketUsedState).HasColumnName("UserTicket_UsedState");

                entity.Property(e => e.UserTicketUserInfoCode).HasColumnName("UserTicket_UserInfoCode");

                entity.Property(e => e.UserTicketVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_VarParamA");

                entity.Property(e => e.UserTicketVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_VarParamB");
            });

            modelBuilder.Entity<TbaseUserticket2>(entity =>
            {
                entity.HasKey(e => e.UserTicketId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userticket2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserTicketUserInfoCode, e.UserTicketCode, e.UserTicketUsedState }, "Index");

                entity.Property(e => e.UserTicketId).HasColumnName("UserTicket_ID");

                entity.Property(e => e.UserTicketBuyModel)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_BuyModel");

                entity.Property(e => e.UserTicketCode).HasColumnName("UserTicket_Code");

                entity.Property(e => e.UserTicketDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_Date");

                entity.Property(e => e.UserTicketExtCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserTicket_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketFloatParamA).HasColumnName("UserTicket_FloatParamA");

                entity.Property(e => e.UserTicketFloatParamB).HasColumnName("UserTicket_FloatParamB");

                entity.Property(e => e.UserTicketIntParamA).HasColumnName("UserTicket_IntParamA");

                entity.Property(e => e.UserTicketIntParamB).HasColumnName("UserTicket_IntParamB");

                entity.Property(e => e.UserTicketLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_LimitDate");

                entity.Property(e => e.UserTicketOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_OpenDate");

                entity.Property(e => e.UserTicketProdCode).HasColumnName("UserTicket_ProdCode");

                entity.Property(e => e.UserTicketQrcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_QRCode");

                entity.Property(e => e.UserTicketRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_RefundDate");

                entity.Property(e => e.UserTicketRefundFee).HasColumnName("UserTicket_RefundFee");

                entity.Property(e => e.UserTicketRefundModel)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_RefundModel");

                entity.Property(e => e.UserTicketState).HasColumnName("UserTicket_State");

                entity.Property(e => e.UserTicketSyncState).HasColumnName("UserTicket_SyncState");

                entity.Property(e => e.UserTicketUniqueId)
                    .HasMaxLength(50)
                    .HasColumnName("UserTicket_UniqueID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketUsedState).HasColumnName("UserTicket_UsedState");

                entity.Property(e => e.UserTicketUserInfoCode).HasColumnName("UserTicket_UserInfoCode");

                entity.Property(e => e.UserTicketVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_VarParamA");

                entity.Property(e => e.UserTicketVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_VarParamB");
            });

            modelBuilder.Entity<TbaseUserticket3>(entity =>
            {
                entity.HasKey(e => e.UserTicketId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userticket3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserTicketUserInfoCode, e.UserTicketCode, e.UserTicketUsedState }, "Index");

                entity.Property(e => e.UserTicketId).HasColumnName("UserTicket_ID");

                entity.Property(e => e.UserTicketBuyModel)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_BuyModel");

                entity.Property(e => e.UserTicketCode).HasColumnName("UserTicket_Code");

                entity.Property(e => e.UserTicketDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_Date");

                entity.Property(e => e.UserTicketExtCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserTicket_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketFloatParamA).HasColumnName("UserTicket_FloatParamA");

                entity.Property(e => e.UserTicketFloatParamB).HasColumnName("UserTicket_FloatParamB");

                entity.Property(e => e.UserTicketIntParamA).HasColumnName("UserTicket_IntParamA");

                entity.Property(e => e.UserTicketIntParamB).HasColumnName("UserTicket_IntParamB");

                entity.Property(e => e.UserTicketLimitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_LimitDate");

                entity.Property(e => e.UserTicketOpenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_OpenDate");

                entity.Property(e => e.UserTicketProdCode).HasColumnName("UserTicket_ProdCode");

                entity.Property(e => e.UserTicketQrcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_QRCode");

                entity.Property(e => e.UserTicketRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicket_RefundDate");

                entity.Property(e => e.UserTicketRefundFee).HasColumnName("UserTicket_RefundFee");

                entity.Property(e => e.UserTicketRefundModel)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_RefundModel");

                entity.Property(e => e.UserTicketState).HasColumnName("UserTicket_State");

                entity.Property(e => e.UserTicketSyncState).HasColumnName("UserTicket_SyncState");

                entity.Property(e => e.UserTicketUniqueId)
                    .HasMaxLength(50)
                    .HasColumnName("UserTicket_UniqueID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketUsedState).HasColumnName("UserTicket_UsedState");

                entity.Property(e => e.UserTicketUserInfoCode).HasColumnName("UserTicket_UserInfoCode");

                entity.Property(e => e.UserTicketVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_VarParamA");

                entity.Property(e => e.UserTicketVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserTicket_VarParamB");
            });

            modelBuilder.Entity<TbaseUserticketlog>(entity =>
            {
                entity.HasKey(e => e.UserTicketLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_userticketlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserTicketLogUserTicketCode, e.UserTicketLogUsedState }, "Index");

                entity.Property(e => e.UserTicketLogId).HasColumnName("UserTicketLog_ID");

                entity.Property(e => e.UserTicketLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicketLog_Date");

                entity.Property(e => e.UserTicketLogFileName)
                    .HasMaxLength(500)
                    .HasColumnName("UserTicketLog_FileName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTicketLogFloatParamA).HasColumnName("UserTicketLog_FloatParamA");

                entity.Property(e => e.UserTicketLogFloatParamB).HasColumnName("UserTicketLog_FloatParamB");

                entity.Property(e => e.UserTicketLogInOutStation).HasColumnName("UserTicketLog_InOutStation");

                entity.Property(e => e.UserTicketLogIntParamA).HasColumnName("UserTicketLog_IntParamA");

                entity.Property(e => e.UserTicketLogIntParamB).HasColumnName("UserTicketLog_IntParamB");

                entity.Property(e => e.UserTicketLogKrtcstate).HasColumnName("UserTicketLog_KRTCState");

                entity.Property(e => e.UserTicketLogState).HasColumnName("UserTicketLog_State");

                entity.Property(e => e.UserTicketLogStateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTicketLog_StateDate");

                entity.Property(e => e.UserTicketLogSyncState).HasColumnName("UserTicketLog_SyncState");

                entity.Property(e => e.UserTicketLogUsedState).HasColumnName("UserTicketLog_UsedState");

                entity.Property(e => e.UserTicketLogUserTicketCode).HasColumnName("UserTicketLog_UserTicketCode");

                entity.Property(e => e.UserTicketLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserTicketLog_VarParamA");

                entity.Property(e => e.UserTicketLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserTicketLog_VarParamB");
            });

            modelBuilder.Entity<TbaseUservoucher1>(entity =>
            {
                entity.HasKey(e => e.UserVoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_uservoucher1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserVoucherCode, e.UserVoucherUserInfoCode, e.UserVoucherVoucherCode, e.UserVoucherUsedType }, "Index");

                entity.Property(e => e.UserVoucherId).HasColumnName("UserVoucher_ID");

                entity.Property(e => e.UserVoucherCode).HasColumnName("UserVoucher_Code");

                entity.Property(e => e.UserVoucherFloatParamA).HasColumnName("UserVoucher_FloatParamA");

                entity.Property(e => e.UserVoucherFloatParamB).HasColumnName("UserVoucher_FloatParamB");

                entity.Property(e => e.UserVoucherIntParamA).HasColumnName("UserVoucher_IntParamA");

                entity.Property(e => e.UserVoucherIntParamB).HasColumnName("UserVoucher_IntParamB");

                entity.Property(e => e.UserVoucherPayOrderTableNo).HasColumnName("UserVoucher_PayOrderTableNo");

                entity.Property(e => e.UserVoucherQrcode)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_QRCode");

                entity.Property(e => e.UserVoucherReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_ReceiveDate");

                entity.Property(e => e.UserVoucherState).HasColumnName("UserVoucher_State");

                entity.Property(e => e.UserVoucherSyncState).HasColumnName("UserVoucher_SyncState");

                entity.Property(e => e.UserVoucherTableNo).HasColumnName("UserVoucher_TableNo");

                entity.Property(e => e.UserVoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedDate");

                entity.Property(e => e.UserVoucherUsedEcstore).HasColumnName("UserVoucher_UsedECStore");

                entity.Property(e => e.UserVoucherUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOffDate");

                entity.Property(e => e.UserVoucherUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOnDate");

                entity.Property(e => e.UserVoucherUsedState).HasColumnName("UserVoucher_UsedState");

                entity.Property(e => e.UserVoucherUsedType).HasColumnName("UserVoucher_UsedType");

                entity.Property(e => e.UserVoucherUserInfoCode).HasColumnName("UserVoucher_UserInfoCode");

                entity.Property(e => e.UserVoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_VarParamA");

                entity.Property(e => e.UserVoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_VarParamB");

                entity.Property(e => e.UserVoucherVoucherCode).HasColumnName("UserVoucher_VoucherCode");

                entity.Property(e => e.UserVoucherVoucherLimitId).HasColumnName("UserVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TbaseUservoucher2>(entity =>
            {
                entity.HasKey(e => e.UserVoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_uservoucher2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserVoucherCode, e.UserVoucherUserInfoCode, e.UserVoucherVoucherCode, e.UserVoucherUsedType }, "Index");

                entity.Property(e => e.UserVoucherId).HasColumnName("UserVoucher_ID");

                entity.Property(e => e.UserVoucherCode).HasColumnName("UserVoucher_Code");

                entity.Property(e => e.UserVoucherFloatParamA).HasColumnName("UserVoucher_FloatParamA");

                entity.Property(e => e.UserVoucherFloatParamB).HasColumnName("UserVoucher_FloatParamB");

                entity.Property(e => e.UserVoucherIntParamA).HasColumnName("UserVoucher_IntParamA");

                entity.Property(e => e.UserVoucherIntParamB).HasColumnName("UserVoucher_IntParamB");

                entity.Property(e => e.UserVoucherPayOrderTableNo).HasColumnName("UserVoucher_PayOrderTableNo");

                entity.Property(e => e.UserVoucherQrcode)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_QRCode");

                entity.Property(e => e.UserVoucherReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_ReceiveDate");

                entity.Property(e => e.UserVoucherState).HasColumnName("UserVoucher_State");

                entity.Property(e => e.UserVoucherSyncState).HasColumnName("UserVoucher_SyncState");

                entity.Property(e => e.UserVoucherTableNo).HasColumnName("UserVoucher_TableNo");

                entity.Property(e => e.UserVoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedDate");

                entity.Property(e => e.UserVoucherUsedEcstore).HasColumnName("UserVoucher_UsedECStore");

                entity.Property(e => e.UserVoucherUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOffDate");

                entity.Property(e => e.UserVoucherUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOnDate");

                entity.Property(e => e.UserVoucherUsedState).HasColumnName("UserVoucher_UsedState");

                entity.Property(e => e.UserVoucherUsedType).HasColumnName("UserVoucher_UsedType");

                entity.Property(e => e.UserVoucherUserInfoCode).HasColumnName("UserVoucher_UserInfoCode");

                entity.Property(e => e.UserVoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_VarParamA");

                entity.Property(e => e.UserVoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_VarParamB");

                entity.Property(e => e.UserVoucherVoucherCode).HasColumnName("UserVoucher_VoucherCode");

                entity.Property(e => e.UserVoucherVoucherLimitId).HasColumnName("UserVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TbaseUservoucher3>(entity =>
            {
                entity.HasKey(e => e.UserVoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_uservoucher3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.UserVoucherCode, e.UserVoucherUserInfoCode, e.UserVoucherVoucherCode, e.UserVoucherUsedType }, "Index");

                entity.Property(e => e.UserVoucherId).HasColumnName("UserVoucher_ID");

                entity.Property(e => e.UserVoucherCode).HasColumnName("UserVoucher_Code");

                entity.Property(e => e.UserVoucherFloatParamA).HasColumnName("UserVoucher_FloatParamA");

                entity.Property(e => e.UserVoucherFloatParamB).HasColumnName("UserVoucher_FloatParamB");

                entity.Property(e => e.UserVoucherIntParamA).HasColumnName("UserVoucher_IntParamA");

                entity.Property(e => e.UserVoucherIntParamB).HasColumnName("UserVoucher_IntParamB");

                entity.Property(e => e.UserVoucherPayOrderTableNo).HasColumnName("UserVoucher_PayOrderTableNo");

                entity.Property(e => e.UserVoucherQrcode)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_QRCode");

                entity.Property(e => e.UserVoucherReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_ReceiveDate");

                entity.Property(e => e.UserVoucherState).HasColumnName("UserVoucher_State");

                entity.Property(e => e.UserVoucherSyncState).HasColumnName("UserVoucher_SyncState");

                entity.Property(e => e.UserVoucherTableNo).HasColumnName("UserVoucher_TableNo");

                entity.Property(e => e.UserVoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedDate");

                entity.Property(e => e.UserVoucherUsedEcstore).HasColumnName("UserVoucher_UsedECStore");

                entity.Property(e => e.UserVoucherUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOffDate");

                entity.Property(e => e.UserVoucherUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOnDate");

                entity.Property(e => e.UserVoucherUsedState).HasColumnName("UserVoucher_UsedState");

                entity.Property(e => e.UserVoucherUsedType).HasColumnName("UserVoucher_UsedType");

                entity.Property(e => e.UserVoucherUserInfoCode).HasColumnName("UserVoucher_UserInfoCode");

                entity.Property(e => e.UserVoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_VarParamA");

                entity.Property(e => e.UserVoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("UserVoucher_VarParamB");

                entity.Property(e => e.UserVoucherVoucherCode).HasColumnName("UserVoucher_VoucherCode");

                entity.Property(e => e.UserVoucherVoucherLimitId).HasColumnName("UserVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TbaseWorkflow>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_workflow");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WorkflowId).HasColumnName("Workflow_ID");

                entity.Property(e => e.WorkflowFloatParamA).HasColumnName("Workflow_FloatParamA");

                entity.Property(e => e.WorkflowFloatParamB).HasColumnName("Workflow_FloatParamB");

                entity.Property(e => e.WorkflowIntParamA).HasColumnName("Workflow_IntParamA");

                entity.Property(e => e.WorkflowIntParamB).HasColumnName("Workflow_IntParamB");

                entity.Property(e => e.WorkflowMemo)
                    .HasColumnType("text")
                    .HasColumnName("Workflow_Memo");

                entity.Property(e => e.WorkflowName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Workflow_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.WorkflowState).HasColumnName("Workflow_State");

                entity.Property(e => e.WorkflowSyncState).HasColumnName("Workflow_SyncState");

                entity.Property(e => e.WorkflowVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Workflow_VarParamA");

                entity.Property(e => e.WorkflowVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Workflow_VarParamB");
            });

            modelBuilder.Entity<TbaseWorkflowpart>(entity =>
            {
                entity.HasKey(e => e.WorkflowPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tbase_workflowpart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.WorkflowPartWorkflowId, e.WorkflowPartDealTypeCode, e.WorkflowPartDealStateCode, e.WorkflowPartNextTableTypeCode, e.WorkflowPartNextDealTypeCode }, "Index");

                entity.Property(e => e.WorkflowPartId).HasColumnName("WorkflowPart_ID");

                entity.Property(e => e.WorkflowPartDataFlow).HasColumnName("WorkflowPart_DataFlow");

                entity.Property(e => e.WorkflowPartDataFlowColumn)
                    .HasColumnType("text")
                    .HasColumnName("WorkflowPart_DataFlowColumn");

                entity.Property(e => e.WorkflowPartDealStateCode).HasColumnName("WorkflowPart_DealStateCode");

                entity.Property(e => e.WorkflowPartDealTypeCode).HasColumnName("WorkflowPart_DealTypeCode");

                entity.Property(e => e.WorkflowPartFloatParamA).HasColumnName("WorkflowPart_FloatParamA");

                entity.Property(e => e.WorkflowPartFloatParamB).HasColumnName("WorkflowPart_FloatParamB");

                entity.Property(e => e.WorkflowPartIntParamA).HasColumnName("WorkflowPart_IntParamA");

                entity.Property(e => e.WorkflowPartIntParamB).HasColumnName("WorkflowPart_IntParamB");

                entity.Property(e => e.WorkflowPartIsIgnoreDealer).HasColumnName("WorkflowPart_IsIgnoreDealer");

                entity.Property(e => e.WorkflowPartMemo)
                    .HasColumnType("text")
                    .HasColumnName("WorkflowPart_Memo");

                entity.Property(e => e.WorkflowPartNextDealTypeCode).HasColumnName("WorkflowPart_NextDealTypeCode");

                entity.Property(e => e.WorkflowPartNextTableTypeCode).HasColumnName("WorkflowPart_NextTableTypeCode");

                entity.Property(e => e.WorkflowPartNotice).HasColumnName("WorkflowPart_Notice");

                entity.Property(e => e.WorkflowPartState).HasColumnName("WorkflowPart_State");

                entity.Property(e => e.WorkflowPartSyncState).HasColumnName("WorkflowPart_SyncState");

                entity.Property(e => e.WorkflowPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("WorkflowPart_VarParamA");

                entity.Property(e => e.WorkflowPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("WorkflowPart_VarParamB");

                entity.Property(e => e.WorkflowPartWorkflowId).HasColumnName("WorkflowPart_WorkflowID");
            });

            modelBuilder.Entity<TecAuthstore>(entity =>
            {
                entity.HasKey(e => e.AuthStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_authstore");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.AuthStoreCompanyCode, e.AuthStoreCode }, "Index");

                entity.Property(e => e.AuthStoreId).HasColumnName("AuthStore_ID");

                entity.Property(e => e.AuthStoreCode).HasColumnName("AuthStore_Code");

                entity.Property(e => e.AuthStoreCompanyCode).HasColumnName("AuthStore_CompanyCode");

                entity.Property(e => e.AuthStoreCountryCode).HasColumnName("AuthStore_CountryCode");

                entity.Property(e => e.AuthStoreFloatParamA).HasColumnName("AuthStore_FloatParamA");

                entity.Property(e => e.AuthStoreFloatParamB).HasColumnName("AuthStore_FloatParamB");

                entity.Property(e => e.AuthStoreIntParamA).HasColumnName("AuthStore_IntParamA");

                entity.Property(e => e.AuthStoreIntParamB).HasColumnName("AuthStore_IntParamB");

                entity.Property(e => e.AuthStoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AuthStore_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AuthStoreState).HasColumnName("AuthStore_State");

                entity.Property(e => e.AuthStoreSyncState).HasColumnName("AuthStore_SyncState");

                entity.Property(e => e.AuthStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("AuthStore_VarParamA");

                entity.Property(e => e.AuthStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("AuthStore_VarParamB");
            });

            modelBuilder.Entity<TecAuthstorepart>(entity =>
            {
                entity.HasKey(e => e.AuthStorePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_authstorepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.AuthStorePartAuthStoreCode, e.AuthStorePartType }, "Index");

                entity.Property(e => e.AuthStorePartId).HasColumnName("AuthStorePart_ID");

                entity.Property(e => e.AuthStorePartAuthStoreCode).HasColumnName("AuthStorePart_AuthStoreCode");

                entity.Property(e => e.AuthStorePartFloatParamA).HasColumnName("AuthStorePart_FloatParamA");

                entity.Property(e => e.AuthStorePartFloatParamB).HasColumnName("AuthStorePart_FloatParamB");

                entity.Property(e => e.AuthStorePartIntParamA).HasColumnName("AuthStorePart_IntParamA");

                entity.Property(e => e.AuthStorePartIntParamB).HasColumnName("AuthStorePart_IntParamB");

                entity.Property(e => e.AuthStorePartState).HasColumnName("AuthStorePart_State");

                entity.Property(e => e.AuthStorePartSyncState).HasColumnName("AuthStorePart_SyncState");

                entity.Property(e => e.AuthStorePartText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("AuthStorePart_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AuthStorePartType).HasColumnName("AuthStorePart_Type");

                entity.Property(e => e.AuthStorePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("AuthStorePart_VarParamA");

                entity.Property(e => e.AuthStorePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("AuthStorePart_VarParamB");
            });

            modelBuilder.Entity<TecCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_cart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.CartUserInfoCode, e.CartCode, e.CartEcstoreCode, e.CartEcstoreName, e.CartState }, "Index");

                entity.Property(e => e.CartId).HasColumnName("Cart_ID");

                entity.Property(e => e.CartAmount).HasColumnName("Cart_Amount");

                entity.Property(e => e.CartAttributeValueCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Cart_AttributeValueCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CartAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Cart_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CartCode).HasColumnName("Cart_Code");

                entity.Property(e => e.CartEcstoreCode).HasColumnName("Cart_ECStoreCode");

                entity.Property(e => e.CartEcstoreName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Cart_ECStoreName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CartFloatParamA).HasColumnName("Cart_FloatParamA");

                entity.Property(e => e.CartFloatParamB).HasColumnName("Cart_FloatParamB");

                entity.Property(e => e.CartInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cart_InsertDate");

                entity.Property(e => e.CartIntParamA).HasColumnName("Cart_IntParamA");

                entity.Property(e => e.CartIntParamB).HasColumnName("Cart_IntParamB");

                entity.Property(e => e.CartOrderId).HasColumnName("Cart_OrderID");

                entity.Property(e => e.CartOrderState).HasColumnName("Cart_OrderState");

                entity.Property(e => e.CartProductCode).HasColumnName("Cart_ProductCode");

                entity.Property(e => e.CartQuantity).HasColumnName("Cart_Quantity");

                entity.Property(e => e.CartState).HasColumnName("Cart_State");

                entity.Property(e => e.CartUserDefineCode).HasColumnName("Cart_UserDefineCode");

                entity.Property(e => e.CartUserDefineName)
                    .HasMaxLength(64)
                    .HasColumnName("Cart_UserDefineName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CartUserInfoCode).HasColumnName("Cart_UserInfoCode");

                entity.Property(e => e.CartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Cart_VarParamA");

                entity.Property(e => e.CartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Cart_VarParamB");
            });

            modelBuilder.Entity<TecEclogistic>(entity =>
            {
                entity.HasKey(e => e.EclogisticsId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_eclogistics");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.EclogisticsEcstoreCode, "Index");

                entity.Property(e => e.EclogisticsId).HasColumnName("ECLogistics_ID");

                entity.Property(e => e.EclogisticsAmount).HasColumnName("ECLogistics_Amount");

                entity.Property(e => e.EclogisticsEcstoreCode).HasColumnName("ECLogistics_ECStoreCode");

                entity.Property(e => e.EclogisticsFloatParamA).HasColumnName("ECLogistics_FloatParamA");

                entity.Property(e => e.EclogisticsFloatParamB).HasColumnName("ECLogistics_FloatParamB");

                entity.Property(e => e.EclogisticsFloatParamC).HasColumnName("ECLogistics_FloatParamC");

                entity.Property(e => e.EclogisticsIntParamA).HasColumnName("ECLogistics_IntParamA");

                entity.Property(e => e.EclogisticsIntParamB).HasColumnName("ECLogistics_IntParamB");

                entity.Property(e => e.EclogisticsIntParamC).HasColumnName("ECLogistics_IntParamC");

                entity.Property(e => e.EclogisticsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECLogistics_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EclogisticsState).HasColumnName("ECLogistics_State");

                entity.Property(e => e.EclogisticsVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECLogistics_VarParamA");

                entity.Property(e => e.EclogisticsVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECLogistics_VarParamB");

                entity.Property(e => e.EclogisticsVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("ECLogistics_VarParamC");
            });

            modelBuilder.Entity<TecEclogisticspart>(entity =>
            {
                entity.HasKey(e => e.EclogisticsPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_eclogisticspart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EclogisticsPartEclogisticsId, e.EclogisticsPartCity, e.EclogisticsPartCountry }, "Index");

                entity.Property(e => e.EclogisticsPartId).HasColumnName("ECLogisticsPart_ID");

                entity.Property(e => e.EclogisticsPartCity).HasColumnName("ECLogisticsPart_City");

                entity.Property(e => e.EclogisticsPartCountry).HasColumnName("ECLogisticsPart_Country");

                entity.Property(e => e.EclogisticsPartEclogisticsId).HasColumnName("ECLogisticsPart_ECLogisticsID");

                entity.Property(e => e.EclogisticsPartFloatParamA).HasColumnName("ECLogisticsPart_FloatParamA");

                entity.Property(e => e.EclogisticsPartFloatParamB).HasColumnName("ECLogisticsPart_FloatParamB");

                entity.Property(e => e.EclogisticsPartFloatParamC).HasColumnName("ECLogisticsPart_FloatParamC");

                entity.Property(e => e.EclogisticsPartIntParamA).HasColumnName("ECLogisticsPart_IntParamA");

                entity.Property(e => e.EclogisticsPartIntParamB).HasColumnName("ECLogisticsPart_IntParamB");

                entity.Property(e => e.EclogisticsPartIntParamC).HasColumnName("ECLogisticsPart_IntParamC");

                entity.Property(e => e.EclogisticsPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECLogisticsPart_VarParamA");

                entity.Property(e => e.EclogisticsPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECLogisticsPart_VarParamB");

                entity.Property(e => e.EclogisticsPartVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("ECLogisticsPart_VarParamC");
            });

            modelBuilder.Entity<TecEcstore>(entity =>
            {
                entity.HasKey(e => e.EcstoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstore");

                entity.HasIndex(e => new { e.EcstoreCompanyCode, e.EcstoreCode, e.EcstoreAccount, e.EcstoreType, e.EcstoreState, e.EcstorePassState }, "Index");

                entity.Property(e => e.EcstoreId).HasColumnName("ECStore_ID");

                entity.Property(e => e.EcstoreAccount)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Account")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreAppUrltarget).HasColumnName("ECStore_AppURLTarget");

                entity.Property(e => e.EcstoreCity).HasColumnName("ECStore_City");

                entity.Property(e => e.EcstoreCode).HasColumnName("ECStore_Code");

                entity.Property(e => e.EcstoreCompanyCode).HasColumnName("ECStore_CompanyCode");

                entity.Property(e => e.EcstoreCountry).HasColumnName("ECStore_Country");

                entity.Property(e => e.EcstoreCountryCode).HasColumnName("ECStore_CountryCode");

                entity.Property(e => e.EcstoreDeliveryUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_DeliveryURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreDemo)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_Demo");

                entity.Property(e => e.EcstoreExtCode)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreFburl)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_FBURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreFeatures)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_Features");

                entity.Property(e => e.EcstoreFloatParamA).HasColumnName("ECStore_FloatParamA");

                entity.Property(e => e.EcstoreFloatParamB).HasColumnName("ECStore_FloatParamB");

                entity.Property(e => e.EcstoreIgurl)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_IGURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage1)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage2)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage3)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage4)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage5)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image5")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStore_InsertDate");

                entity.Property(e => e.EcstoreIntParamA).HasColumnName("ECStore_IntParamA");

                entity.Property(e => e.EcstoreIntParamB).HasColumnName("ECStore_IntParamB");

                entity.Property(e => e.EcstoreIsOnline).HasColumnName("ECStore_IsOnline");

                entity.Property(e => e.EcstoreIsPayment).HasColumnName("ECStore_IsPayment");

                entity.Property(e => e.EcstoreIsPraise).HasColumnName("ECStore_IsPraise");

                entity.Property(e => e.EcstoreIsRecomm).HasColumnName("ECStore_IsRecomm");

                entity.Property(e => e.EcstoreIsSelfpick).HasColumnName("ECStore_IsSelfpick");

                entity.Property(e => e.EcstoreJustKa)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_JustKa")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLat).HasColumnName("ECStore_Lat");

                entity.Property(e => e.EcstoreLineUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_LineURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLng).HasColumnName("ECStore_Lng");

                entity.Property(e => e.EcstoreLocalCityArea).HasColumnName("ECStore_LocalCityArea");

                entity.Property(e => e.EcstoreLogo)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Logo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreNearby)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Nearby")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreOpenTime)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_OpenTime")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePassDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStore_PassDate");

                entity.Property(e => e.EcstorePassDealerCode).HasColumnName("ECStore_PassDealerCode");

                entity.Property(e => e.EcstorePassState).HasColumnName("ECStore_PassState");

                entity.Property(e => e.EcstorePickAddress)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_PickAddress")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePickCity).HasColumnName("ECStore_PickCity");

                entity.Property(e => e.EcstorePickCityArea).HasColumnName("ECStore_PickCityArea");

                entity.Property(e => e.EcstorePointFee).HasColumnName("ECStore_PointFee");

                entity.Property(e => e.EcstoreShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreState).HasColumnName("ECStore_State");

                entity.Property(e => e.EcstoreSyncState).HasColumnName("ECStore_SyncState");

                entity.Property(e => e.EcstoreTakeoutAppUrltarget).HasColumnName("ECStore_TakeoutAppURLTarget");

                entity.Property(e => e.EcstoreTakeoutUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_TakeoutURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreTel)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Tel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreTemplateState).HasColumnName("ECStore_TemplateState");

                entity.Property(e => e.EcstoreType).HasColumnName("ECStore_Type");

                entity.Property(e => e.EcstoreUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStore_UpdateDate");

                entity.Property(e => e.EcstoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_VarParamA");

                entity.Property(e => e.EcstoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_VarParamB");

                entity.Property(e => e.EcstoreWebUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_WebURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TecEcstoreattr>(entity =>
            {
                entity.HasKey(e => e.EcstoreAttrId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstoreattr");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcstoreAttrEcstoreCode, e.EcstoreAttrAttributeCode, e.EcstoreAttrAttributeType, e.EcstoreAttrAttributeValueCode }, "Index");

                entity.Property(e => e.EcstoreAttrId).HasColumnName("ECStoreAttr_ID");

                entity.Property(e => e.EcstoreAttrAttributeCode).HasColumnName("ECStoreAttr_AttributeCode");

                entity.Property(e => e.EcstoreAttrAttributeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStoreAttr_AttributeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreAttrAttributeType).HasColumnName("ECStoreAttr_AttributeType");

                entity.Property(e => e.EcstoreAttrAttributeValueCode).HasColumnName("ECStoreAttr_AttributeValueCode");

                entity.Property(e => e.EcstoreAttrAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStoreAttr_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreAttrEcstoreCode).HasColumnName("ECStoreAttr_ECStoreCode");

                entity.Property(e => e.EcstoreAttrFloatParamA).HasColumnName("ECStoreAttr_FloatParamA");

                entity.Property(e => e.EcstoreAttrFloatParamB).HasColumnName("ECStoreAttr_FloatParamB");

                entity.Property(e => e.EcstoreAttrIntParamA).HasColumnName("ECStoreAttr_IntParamA");

                entity.Property(e => e.EcstoreAttrIntParamB).HasColumnName("ECStoreAttr_IntParamB");

                entity.Property(e => e.EcstoreAttrIsShow).HasColumnName("ECStoreAttr_IsShow");

                entity.Property(e => e.EcstoreAttrSyncState).HasColumnName("ECStoreAttr_SyncState");

                entity.Property(e => e.EcstoreAttrVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreAttr_VarParamA");

                entity.Property(e => e.EcstoreAttrVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreAttr_VarParamB");
            });

            modelBuilder.Entity<TecEcstoreexttype>(entity =>
            {
                entity.HasKey(e => e.EcstoreExtTypeId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstoreexttype");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcstoreExtTypeEcstoreCode, e.EcstoreExtTypePartnerCode, e.EcstoreExtTypeType, e.EcstoreExtTypeExtCode }, "Index");

                entity.Property(e => e.EcstoreExtTypeId).HasColumnName("ECStoreExtType_ID");

                entity.Property(e => e.EcstoreExtTypeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStoreExtType_Date");

                entity.Property(e => e.EcstoreExtTypeEcstoreCode).HasColumnName("ECStoreExtType_ECStoreCode");

                entity.Property(e => e.EcstoreExtTypeExtCode)
                    .HasMaxLength(100)
                    .HasColumnName("ECStoreExtType_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreExtTypeExtName)
                    .HasMaxLength(50)
                    .HasColumnName("ECStoreExtType_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreExtTypeFloatParamA).HasColumnName("ECStoreExtType_FloatParamA");

                entity.Property(e => e.EcstoreExtTypeFloatParamB).HasColumnName("ECStoreExtType_FloatParamB");

                entity.Property(e => e.EcstoreExtTypeIntParamA).HasColumnName("ECStoreExtType_IntParamA");

                entity.Property(e => e.EcstoreExtTypeIntParamB).HasColumnName("ECStoreExtType_IntParamB");

                entity.Property(e => e.EcstoreExtTypePartnerCode).HasColumnName("ECStoreExtType_PartnerCode");

                entity.Property(e => e.EcstoreExtTypeState).HasColumnName("ECStoreExtType_State");

                entity.Property(e => e.EcstoreExtTypeSyncState).HasColumnName("ECStoreExtType_SyncState");

                entity.Property(e => e.EcstoreExtTypeType).HasColumnName("ECStoreExtType_Type");

                entity.Property(e => e.EcstoreExtTypeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreExtType_VarParamA");

                entity.Property(e => e.EcstoreExtTypeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreExtType_VarParamB");
            });

            modelBuilder.Entity<TecEcstorelink>(entity =>
            {
                entity.HasKey(e => e.EcstoreLinkId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstorelink");

                entity.Property(e => e.EcstoreLinkId).HasColumnName("ECStoreLink_ID");

                entity.Property(e => e.EcstoreLinkEcstoreCode).HasColumnName("ECStoreLink_ECStoreCode");

                entity.Property(e => e.EcstoreLinkFloatParamA).HasColumnName("ECStoreLink_FloatParamA");

                entity.Property(e => e.EcstoreLinkFloatParamB).HasColumnName("ECStoreLink_FloatParamB");

                entity.Property(e => e.EcstoreLinkIcon)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ECStoreLink_Icon")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLinkInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStoreLink_InsertDate");

                entity.Property(e => e.EcstoreLinkIntParamA).HasColumnName("ECStoreLink_IntParamA");

                entity.Property(e => e.EcstoreLinkIntParamB).HasColumnName("ECStoreLink_IntParamB");

                entity.Property(e => e.EcstoreLinkName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ECStoreLink_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLinkSort).HasColumnName("ECStoreLink_Sort");

                entity.Property(e => e.EcstoreLinkState).HasColumnName("ECStoreLink_State");

                entity.Property(e => e.EcstoreLinkSyncState).HasColumnName("ECStoreLink_SyncState");

                entity.Property(e => e.EcstoreLinkUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ECStoreLink_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLinkUrltarget)
                    .HasMaxLength(10)
                    .HasColumnName("ECStoreLink_URLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLinkVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreLink_VarParamA");

                entity.Property(e => e.EcstoreLinkVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreLink_VarParamB");
            });

            modelBuilder.Entity<TecEcstorepart>(entity =>
            {
                entity.HasKey(e => e.EcstorePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstorepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcstorePartEcstoreCode, e.EcstorePartHistoricType }, "Index");

                entity.Property(e => e.EcstorePartId).HasColumnName("ECStorePart_ID");

                entity.Property(e => e.EcstorePartEcstoreCode).HasColumnName("ECStorePart_ECStoreCode");

                entity.Property(e => e.EcstorePartFloatParamA).HasColumnName("ECStorePart_FloatParamA");

                entity.Property(e => e.EcstorePartFloatParamB).HasColumnName("ECStorePart_FloatParamB");

                entity.Property(e => e.EcstorePartHistoricPost)
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePart_HistoricPost")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePartHistoricType)
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePart_HistoricType")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePartIntParamA).HasColumnName("ECStorePart_IntParamA");

                entity.Property(e => e.EcstorePartIntParamB).HasColumnName("ECStorePart_IntParamB");

                entity.Property(e => e.EcstorePartRooms).HasColumnName("ECStorePart_Rooms");

                entity.Property(e => e.EcstorePartStar)
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePart_Star")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePartState).HasColumnName("ECStorePart_State");

                entity.Property(e => e.EcstorePartSyncState).HasColumnName("ECStorePart_SyncState");

                entity.Property(e => e.EcstorePartTicketInfo)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePart_TicketInfo");

                entity.Property(e => e.EcstorePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePart_VarParamA");

                entity.Property(e => e.EcstorePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePart_VarParamB");
            });

            modelBuilder.Entity<TecEcstoreparttemp>(entity =>
            {
                entity.HasKey(e => e.EcstorePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstoreparttemp");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcstorePartEcstoreCode, e.EcstorePartHistoricType }, "Index");

                entity.Property(e => e.EcstorePartId).HasColumnName("ECStorePart_ID");

                entity.Property(e => e.EcstorePartEcstoreCode).HasColumnName("ECStorePart_ECStoreCode");

                entity.Property(e => e.EcstorePartFloatParamA).HasColumnName("ECStorePart_FloatParamA");

                entity.Property(e => e.EcstorePartFloatParamB).HasColumnName("ECStorePart_FloatParamB");

                entity.Property(e => e.EcstorePartHistoricPost)
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePart_HistoricPost")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePartHistoricType)
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePart_HistoricType")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePartIntParamA).HasColumnName("ECStorePart_IntParamA");

                entity.Property(e => e.EcstorePartIntParamB).HasColumnName("ECStorePart_IntParamB");

                entity.Property(e => e.EcstorePartRooms).HasColumnName("ECStorePart_Rooms");

                entity.Property(e => e.EcstorePartStar)
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePart_Star")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePartState).HasColumnName("ECStorePart_State");

                entity.Property(e => e.EcstorePartSyncState).HasColumnName("ECStorePart_SyncState");

                entity.Property(e => e.EcstorePartTicketInfo)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePart_TicketInfo");

                entity.Property(e => e.EcstorePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePart_VarParamA");

                entity.Property(e => e.EcstorePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePart_VarParamB");
            });

            modelBuilder.Entity<TecEcstorepaymentmap>(entity =>
            {
                entity.HasKey(e => e.EcstorePaymentMapId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstorepaymentmap");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcstorePaymentMapCompanyCode, e.EcstorePaymentMapEcstoreCode, e.EcstorePaymentMapContractStore, e.EcstorePaymentMapCspaymentId }, "Index");

                entity.Property(e => e.EcstorePaymentMapId).HasColumnName("ECStorePaymentMap_ID");

                entity.Property(e => e.EcstorePaymentMapCompanyCode).HasColumnName("ECStorePaymentMap_CompanyCode");

                entity.Property(e => e.EcstorePaymentMapContractStore).HasColumnName("ECStorePaymentMap_ContractStore");

                entity.Property(e => e.EcstorePaymentMapCspaymentId).HasColumnName("ECStorePaymentMap_CSPaymentID");

                entity.Property(e => e.EcstorePaymentMapCspaymentShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStorePaymentMap_CSPaymentShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePaymentMapEcstoreCode).HasColumnName("ECStorePaymentMap_ECStoreCode");

                entity.Property(e => e.EcstorePaymentMapFloatParamA).HasColumnName("ECStorePaymentMap_FloatParamA");

                entity.Property(e => e.EcstorePaymentMapFloatParamB).HasColumnName("ECStorePaymentMap_FloatParamB");

                entity.Property(e => e.EcstorePaymentMapIntParamA).HasColumnName("ECStorePaymentMap_IntParamA");

                entity.Property(e => e.EcstorePaymentMapIntParamB).HasColumnName("ECStorePaymentMap_IntParamB");

                entity.Property(e => e.EcstorePaymentMapState).HasColumnName("ECStorePaymentMap_State");

                entity.Property(e => e.EcstorePaymentMapSyncState).HasColumnName("ECStorePaymentMap_SyncState");

                entity.Property(e => e.EcstorePaymentMapVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePaymentMap_VarParamA");

                entity.Property(e => e.EcstorePaymentMapVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStorePaymentMap_VarParamB");
            });

            modelBuilder.Entity<TecEcstoreprodlist>(entity =>
            {
                entity.HasKey(e => e.EcstoreProdListId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstoreprodlist");

                entity.Property(e => e.EcstoreProdListId).HasColumnName("ECStoreProdList_ID");

                entity.Property(e => e.EcstoreProdListEcstoreCode).HasColumnName("ECStoreProdList_ECStoreCode");

                entity.Property(e => e.EcstoreProdListFloatParamA).HasColumnName("ECStoreProdList_FloatParamA");

                entity.Property(e => e.EcstoreProdListFloatParamB).HasColumnName("ECStoreProdList_FloatParamB");

                entity.Property(e => e.EcstoreProdListIntParamA).HasColumnName("ECStoreProdList_IntParamA");

                entity.Property(e => e.EcstoreProdListIntParamB).HasColumnName("ECStoreProdList_IntParamB");

                entity.Property(e => e.EcstoreProdListProdListCode).HasColumnName("ECStoreProdList_ProdListCode");

                entity.Property(e => e.EcstoreProdListSyncState).HasColumnName("ECStoreProdList_SyncState");

                entity.Property(e => e.EcstoreProdListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreProdList_VarParamA");

                entity.Property(e => e.EcstoreProdListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStoreProdList_VarParamB");
            });

            modelBuilder.Entity<TecEcstoretemp>(entity =>
            {
                entity.HasKey(e => e.EcstoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecstoretemp");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcstoreCompanyCode, e.EcstoreCode }, "Index");

                entity.Property(e => e.EcstoreId).HasColumnName("ECStore_ID");

                entity.Property(e => e.EcstoreAccount)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Account")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreAddress)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreCity).HasColumnName("ECStore_City");

                entity.Property(e => e.EcstoreCode).HasColumnName("ECStore_Code");

                entity.Property(e => e.EcstoreCompanyCode).HasColumnName("ECStore_CompanyCode");

                entity.Property(e => e.EcstoreCountry).HasColumnName("ECStore_Country");

                entity.Property(e => e.EcstoreCountryCode).HasColumnName("ECStore_CountryCode");

                entity.Property(e => e.EcstoreDemo)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_Demo");

                entity.Property(e => e.EcstoreExtCode)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreFburl)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_FBURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreFeatures)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_Features");

                entity.Property(e => e.EcstoreFloatParamA).HasColumnName("ECStore_FloatParamA");

                entity.Property(e => e.EcstoreFloatParamB).HasColumnName("ECStore_FloatParamB");

                entity.Property(e => e.EcstoreIgurl)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_IGURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage1)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage2)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage3)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage4)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreImage5)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Image5")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStore_InsertDate");

                entity.Property(e => e.EcstoreIntParamA).HasColumnName("ECStore_IntParamA");

                entity.Property(e => e.EcstoreIntParamB).HasColumnName("ECStore_IntParamB");

                entity.Property(e => e.EcstoreIsOnline).HasColumnName("ECStore_IsOnline");

                entity.Property(e => e.EcstoreIsPraise).HasColumnName("ECStore_IsPraise");

                entity.Property(e => e.EcstoreIsRecomm).HasColumnName("ECStore_IsRecomm");

                entity.Property(e => e.EcstoreLat).HasColumnName("ECStore_Lat");

                entity.Property(e => e.EcstoreLineUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_LineURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreLng).HasColumnName("ECStore_Lng");

                entity.Property(e => e.EcstoreLocalCityArea).HasColumnName("ECStore_LocalCityArea");

                entity.Property(e => e.EcstoreLogo)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_Logo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreOpenTime)
                    .HasMaxLength(500)
                    .HasColumnName("ECStore_OpenTime")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstorePassDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStore_PassDate");

                entity.Property(e => e.EcstorePassDealerCode).HasColumnName("ECStore_PassDealerCode");

                entity.Property(e => e.EcstorePassState).HasColumnName("ECStore_PassState");

                entity.Property(e => e.EcstoreShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreState).HasColumnName("ECStore_State");

                entity.Property(e => e.EcstoreSyncState).HasColumnName("ECStore_SyncState");

                entity.Property(e => e.EcstoreTel)
                    .HasMaxLength(50)
                    .HasColumnName("ECStore_Tel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EcstoreTempState).HasColumnName("ECStore_TempState");

                entity.Property(e => e.EcstoreType).HasColumnName("ECStore_Type");

                entity.Property(e => e.EcstoreUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECStore_UpdateDate");

                entity.Property(e => e.EcstoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_VarParamA");

                entity.Property(e => e.EcstoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECStore_VarParamB");

                entity.Property(e => e.EcstoreWebUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ECStore_WebURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TecEcvoucher1>(entity =>
            {
                entity.HasKey(e => e.EcvoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecvoucher1");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcvoucherUserVoucherCode, e.EcvoucherEcstoreCode, e.EcvoucherUserInfoCode, e.EcvoucherVoucherCode }, "Index");

                entity.Property(e => e.EcvoucherId).HasColumnName("ECVoucher_ID");

                entity.Property(e => e.EcvoucherCheckState).HasColumnName("ECVoucher_CheckState");

                entity.Property(e => e.EcvoucherCostPrice).HasColumnName("ECVoucher_CostPrice");

                entity.Property(e => e.EcvoucherDiscount).HasColumnName("ECVoucher_Discount");

                entity.Property(e => e.EcvoucherEcstoreCode).HasColumnName("ECVoucher_ECStoreCode");

                entity.Property(e => e.EcvoucherEcuserInfoCode).HasColumnName("ECVoucher_ECUserInfoCode");

                entity.Property(e => e.EcvoucherFloatParamA).HasColumnName("ECVoucher_FloatParamA");

                entity.Property(e => e.EcvoucherFloatParamB).HasColumnName("ECVoucher_FloatParamB");

                entity.Property(e => e.EcvoucherIntParamA).HasColumnName("ECVoucher_IntParamA");

                entity.Property(e => e.EcvoucherIntParamB).HasColumnName("ECVoucher_IntParamB");

                entity.Property(e => e.EcvoucherMainStoreCode).HasColumnName("ECVoucher_MainStoreCode");

                entity.Property(e => e.EcvoucherPayOrderTableNo).HasColumnName("ECVoucher_PayOrderTableNo");

                entity.Property(e => e.EcvoucherState).HasColumnName("ECVoucher_State");

                entity.Property(e => e.EcvoucherSyncState).HasColumnName("ECVoucher_SyncState");

                entity.Property(e => e.EcvoucherTableNo).HasColumnName("ECVoucher_TableNo");

                entity.Property(e => e.EcvoucherTemplateState).HasColumnName("ECVoucher_TemplateState");

                entity.Property(e => e.EcvoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECVoucher_UsedDate");

                entity.Property(e => e.EcvoucherUserInfoCode).HasColumnName("ECVoucher_UserInfoCode");

                entity.Property(e => e.EcvoucherUserVoucherCode).HasColumnName("ECVoucher_UserVoucherCode");

                entity.Property(e => e.EcvoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECVoucher_VarParamA");

                entity.Property(e => e.EcvoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECVoucher_VarParamB");

                entity.Property(e => e.EcvoucherVoucherCode).HasColumnName("ECVoucher_VoucherCode");

                entity.Property(e => e.EcvoucherVoucherLimitId).HasColumnName("ECVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TecEcvoucher2>(entity =>
            {
                entity.HasKey(e => e.EcvoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecvoucher2");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcvoucherEcstoreCode, e.EcvoucherUserVoucherCode, e.EcvoucherUserInfoCode, e.EcvoucherVoucherCode }, "Index");

                entity.Property(e => e.EcvoucherId).HasColumnName("ECVoucher_ID");

                entity.Property(e => e.EcvoucherCheckState).HasColumnName("ECVoucher_CheckState");

                entity.Property(e => e.EcvoucherCostPrice).HasColumnName("ECVoucher_CostPrice");

                entity.Property(e => e.EcvoucherDiscount).HasColumnName("ECVoucher_Discount");

                entity.Property(e => e.EcvoucherEcstoreCode).HasColumnName("ECVoucher_ECStoreCode");

                entity.Property(e => e.EcvoucherEcuserInfoCode).HasColumnName("ECVoucher_ECUserInfoCode");

                entity.Property(e => e.EcvoucherFloatParamA).HasColumnName("ECVoucher_FloatParamA");

                entity.Property(e => e.EcvoucherFloatParamB).HasColumnName("ECVoucher_FloatParamB");

                entity.Property(e => e.EcvoucherIntParamA).HasColumnName("ECVoucher_IntParamA");

                entity.Property(e => e.EcvoucherIntParamB).HasColumnName("ECVoucher_IntParamB");

                entity.Property(e => e.EcvoucherMainStoreCode).HasColumnName("ECVoucher_MainStoreCode");

                entity.Property(e => e.EcvoucherPayOrderTableNo).HasColumnName("ECVoucher_PayOrderTableNo");

                entity.Property(e => e.EcvoucherState).HasColumnName("ECVoucher_State");

                entity.Property(e => e.EcvoucherSyncState).HasColumnName("ECVoucher_SyncState");

                entity.Property(e => e.EcvoucherTableNo).HasColumnName("ECVoucher_TableNo");

                entity.Property(e => e.EcvoucherTemplateState).HasColumnName("ECVoucher_TemplateState");

                entity.Property(e => e.EcvoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECVoucher_UsedDate");

                entity.Property(e => e.EcvoucherUserInfoCode).HasColumnName("ECVoucher_UserInfoCode");

                entity.Property(e => e.EcvoucherUserVoucherCode).HasColumnName("ECVoucher_UserVoucherCode");

                entity.Property(e => e.EcvoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECVoucher_VarParamA");

                entity.Property(e => e.EcvoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECVoucher_VarParamB");

                entity.Property(e => e.EcvoucherVoucherCode).HasColumnName("ECVoucher_VoucherCode");

                entity.Property(e => e.EcvoucherVoucherLimitId).HasColumnName("ECVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TecEcvoucher3>(entity =>
            {
                entity.HasKey(e => e.EcvoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tec_ecvoucher3");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.EcvoucherMainStoreCode, e.EcvoucherEcstoreCode, e.EcvoucherUserVoucherCode, e.EcvoucherUserInfoCode, e.EcvoucherVoucherCode }, "Index");

                entity.Property(e => e.EcvoucherId).HasColumnName("ECVoucher_ID");

                entity.Property(e => e.EcvoucherCheckState).HasColumnName("ECVoucher_CheckState");

                entity.Property(e => e.EcvoucherCostPrice).HasColumnName("ECVoucher_CostPrice");

                entity.Property(e => e.EcvoucherDiscount).HasColumnName("ECVoucher_Discount");

                entity.Property(e => e.EcvoucherEcstoreCode).HasColumnName("ECVoucher_ECStoreCode");

                entity.Property(e => e.EcvoucherEcuserInfoCode).HasColumnName("ECVoucher_ECUserInfoCode");

                entity.Property(e => e.EcvoucherFloatParamA).HasColumnName("ECVoucher_FloatParamA");

                entity.Property(e => e.EcvoucherFloatParamB).HasColumnName("ECVoucher_FloatParamB");

                entity.Property(e => e.EcvoucherIntParamA).HasColumnName("ECVoucher_IntParamA");

                entity.Property(e => e.EcvoucherIntParamB).HasColumnName("ECVoucher_IntParamB");

                entity.Property(e => e.EcvoucherMainStoreCode).HasColumnName("ECVoucher_MainStoreCode");

                entity.Property(e => e.EcvoucherPayOrderTableNo).HasColumnName("ECVoucher_PayOrderTableNo");

                entity.Property(e => e.EcvoucherState).HasColumnName("ECVoucher_State");

                entity.Property(e => e.EcvoucherSyncState).HasColumnName("ECVoucher_SyncState");

                entity.Property(e => e.EcvoucherTableNo).HasColumnName("ECVoucher_TableNo");

                entity.Property(e => e.EcvoucherTemplateState).HasColumnName("ECVoucher_TemplateState");

                entity.Property(e => e.EcvoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECVoucher_UsedDate");

                entity.Property(e => e.EcvoucherUserInfoCode).HasColumnName("ECVoucher_UserInfoCode");

                entity.Property(e => e.EcvoucherUserVoucherCode).HasColumnName("ECVoucher_UserVoucherCode");

                entity.Property(e => e.EcvoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ECVoucher_VarParamA");

                entity.Property(e => e.EcvoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ECVoucher_VarParamB");

                entity.Property(e => e.EcvoucherVoucherCode).HasColumnName("ECVoucher_VoucherCode");

                entity.Property(e => e.EcvoucherVoucherLimitId).HasColumnName("ECVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TecEcvoucherview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tec_ecvoucherview");

                entity.Property(e => e.EcvoucherCheckState).HasColumnName("ECVoucher_CheckState");

                entity.Property(e => e.EcvoucherCostPrice).HasColumnName("ECVoucher_CostPrice");

                entity.Property(e => e.EcvoucherDiscount).HasColumnName("ECVoucher_Discount");

                entity.Property(e => e.EcvoucherEcstoreCode).HasColumnName("ECVoucher_ECStoreCode");

                entity.Property(e => e.EcvoucherEcuserInfoCode).HasColumnName("ECVoucher_ECUserInfoCode");

                entity.Property(e => e.EcvoucherFloatParamA).HasColumnName("ECVoucher_FloatParamA");

                entity.Property(e => e.EcvoucherFloatParamB).HasColumnName("ECVoucher_FloatParamB");

                entity.Property(e => e.EcvoucherId).HasColumnName("ECVoucher_ID");

                entity.Property(e => e.EcvoucherIntParamA).HasColumnName("ECVoucher_IntParamA");

                entity.Property(e => e.EcvoucherIntParamB).HasColumnName("ECVoucher_IntParamB");

                entity.Property(e => e.EcvoucherMainStoreCode).HasColumnName("ECVoucher_MainStoreCode");

                entity.Property(e => e.EcvoucherPayOrderTableNo).HasColumnName("ECVoucher_PayOrderTableNo");

                entity.Property(e => e.EcvoucherState).HasColumnName("ECVoucher_State");

                entity.Property(e => e.EcvoucherSyncState).HasColumnName("ECVoucher_SyncState");

                entity.Property(e => e.EcvoucherTableNo).HasColumnName("ECVoucher_TableNo");

                entity.Property(e => e.EcvoucherTemplateState).HasColumnName("ECVoucher_TemplateState");

                entity.Property(e => e.EcvoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECVoucher_UsedDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.EcvoucherUserInfoCode).HasColumnName("ECVoucher_UserInfoCode");

                entity.Property(e => e.EcvoucherUserVoucherCode).HasColumnName("ECVoucher_UserVoucherCode");

                entity.Property(e => e.EcvoucherVarParamA)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ECVoucher_VarParamA")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EcvoucherVarParamB)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ECVoucher_VarParamB")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EcvoucherVoucherCode).HasColumnName("ECVoucher_VoucherCode");

                entity.Property(e => e.EcvoucherVoucherLimitId).HasColumnName("ECVoucher_VoucherLimitID");
            });

            modelBuilder.Entity<TerpApplyinfopart>(entity =>
            {
                entity.HasKey(e => e.ApplyInfoPartId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_applyinfopart");

                entity.HasIndex(e => new { e.ApplyInfoPartTableNo, e.ApplyInfoPartOtherCode, e.ApplyInfoPartUserInfoCode }, "Index");

                entity.Property(e => e.ApplyInfoPartId).HasColumnName("ApplyInfoPart_ID");

                entity.Property(e => e.ApplyInfoPartFloatParamA).HasColumnName("ApplyInfoPart_FloatParamA");

                entity.Property(e => e.ApplyInfoPartFloatParamB).HasColumnName("ApplyInfoPart_FloatParamB");

                entity.Property(e => e.ApplyInfoPartIntParamA).HasColumnName("ApplyInfoPart_IntParamA");

                entity.Property(e => e.ApplyInfoPartIntParamB).HasColumnName("ApplyInfoPart_IntParamB");

                entity.Property(e => e.ApplyInfoPartOtherCode).HasColumnName("ApplyInfoPart_OtherCode");

                entity.Property(e => e.ApplyInfoPartState).HasColumnName("ApplyInfoPart_State");

                entity.Property(e => e.ApplyInfoPartSyncState).HasColumnName("ApplyInfoPart_SyncState");

                entity.Property(e => e.ApplyInfoPartTableNo).HasColumnName("ApplyInfoPart_TableNo");

                entity.Property(e => e.ApplyInfoPartUserInfoCode).HasColumnName("ApplyInfoPart_UserInfoCode");

                entity.Property(e => e.ApplyInfoPartUserInfoGroupNo).HasColumnName("ApplyInfoPart_UserInfoGroupNo");

                entity.Property(e => e.ApplyInfoPartUserInfoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ApplyInfoPart_UserInfoName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApplyInfoPartUserInfoUuid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ApplyInfoPart_UserInfoUUID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApplyInfoPartUserState).HasColumnName("ApplyInfoPart_UserState");

                entity.Property(e => e.ApplyInfoPartValidMsg)
                    .HasMaxLength(50)
                    .HasColumnName("ApplyInfoPart_ValidMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ApplyInfoPartValidState).HasColumnName("ApplyInfoPart_ValidState");

                entity.Property(e => e.ApplyInfoPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ApplyInfoPart_VarParamA");

                entity.Property(e => e.ApplyInfoPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ApplyInfoPart_VarParamB");
            });

            modelBuilder.Entity<TerpDeliveryorder>(entity =>
            {
                entity.HasKey(e => e.DeliveryOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_deliveryorder");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.DeliveryOrderPartnerCode, e.DeliveryOrderCode, e.DeliveryOrderEcstoreCode, e.DeliveryOrderUserInfoCode }, "Index");

                entity.Property(e => e.DeliveryOrderId).HasColumnName("DeliveryOrder_ID");

                entity.Property(e => e.DeliveryOrderCode).HasColumnName("DeliveryOrder_Code");

                entity.Property(e => e.DeliveryOrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryOrder_Date");

                entity.Property(e => e.DeliveryOrderEcstoreCode).HasColumnName("DeliveryOrder_ECStoreCode");

                entity.Property(e => e.DeliveryOrderExtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryOrder_ExtDate");

                entity.Property(e => e.DeliveryOrderExtId)
                    .HasMaxLength(100)
                    .HasColumnName("DeliveryOrder_ExtID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DeliveryOrderExtNo)
                    .HasMaxLength(100)
                    .HasColumnName("DeliveryOrder_ExtNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DeliveryOrderExtState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DeliveryOrder_ExtState")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DeliveryOrderFloatParamA).HasColumnName("DeliveryOrder_FloatParamA");

                entity.Property(e => e.DeliveryOrderFloatParamB).HasColumnName("DeliveryOrder_FloatParamB");

                entity.Property(e => e.DeliveryOrderIntParamA).HasColumnName("DeliveryOrder_IntParamA");

                entity.Property(e => e.DeliveryOrderIntParamB).HasColumnName("DeliveryOrder_IntParamB");

                entity.Property(e => e.DeliveryOrderPartnerCode).HasColumnName("DeliveryOrder_PartnerCode");

                entity.Property(e => e.DeliveryOrderState).HasColumnName("DeliveryOrder_State");

                entity.Property(e => e.DeliveryOrderUserInfoCode).HasColumnName("DeliveryOrder_UserInfoCode");

                entity.Property(e => e.DeliveryOrderVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("DeliveryOrder_VarParamA");

                entity.Property(e => e.DeliveryOrderVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("DeliveryOrder_VarParamB");
            });

            modelBuilder.Entity<TerpMainstore>(entity =>
            {
                entity.HasKey(e => e.MainStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_mainstore");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.MainStoreTableNo, e.MainStoreCompanyCode, e.MainStoreContractStoreCode }, "Index");

                entity.Property(e => e.MainStoreId).HasColumnName("MainStore_ID");

                entity.Property(e => e.MainStoreCompanyCode).HasColumnName("MainStore_CompanyCode");

                entity.Property(e => e.MainStoreCompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MainStore_CompanyName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MainStoreContactCell)
                    .HasMaxLength(50)
                    .HasColumnName("MainStore_ContactCell")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MainStoreContactName)
                    .HasMaxLength(100)
                    .HasColumnName("MainStore_ContactName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MainStoreContactTel)
                    .HasMaxLength(50)
                    .HasColumnName("MainStore_ContactTel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MainStoreContractStoreCode).HasColumnName("MainStore_ContractStoreCode");

                entity.Property(e => e.MainStoreFloatParamA).HasColumnName("MainStore_FloatParamA");

                entity.Property(e => e.MainStoreFloatParamB).HasColumnName("MainStore_FloatParamB");

                entity.Property(e => e.MainStoreFloatParamC).HasColumnName("MainStore_FloatParamC");

                entity.Property(e => e.MainStoreInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MainStore_InsertDate");

                entity.Property(e => e.MainStoreIntParamA).HasColumnName("MainStore_IntParamA");

                entity.Property(e => e.MainStoreIntParamB).HasColumnName("MainStore_IntParamB");

                entity.Property(e => e.MainStoreIntParamC).HasColumnName("MainStore_IntParamC");

                entity.Property(e => e.MainStoreState).HasColumnName("MainStore_State");

                entity.Property(e => e.MainStoreSyncState).HasColumnName("MainStore_SyncState");

                entity.Property(e => e.MainStoreTableNo).HasColumnName("MainStore_TableNo");

                entity.Property(e => e.MainStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MainStore_VarParamA");

                entity.Property(e => e.MainStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MainStore_VarParamB");

                entity.Property(e => e.MainStoreVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("MainStore_VarParamC");
            });

            modelBuilder.Entity<TerpOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_order");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.OrderTableNo, e.OrderPayOrderTableNo, e.OrderEcstoreCode, e.OrderMainStoreCode, e.OrderUserInfoCode }, "Index");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.OrderAmount).HasColumnName("Order_Amount");

                entity.Property(e => e.OrderAppreciationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_AppreciationDate");

                entity.Property(e => e.OrderArrivalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_ArrivalDate");

                entity.Property(e => e.OrderChangeAmount).HasColumnName("Order_ChangeAmount");

                entity.Property(e => e.OrderChangeShippingAmount).HasColumnName("Order_ChangeShippingAmount");

                entity.Property(e => e.OrderConsumerMsg)
                    .HasMaxLength(500)
                    .HasColumnName("Order_ConsumerMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderCurrency)
                    .HasMaxLength(5)
                    .HasColumnName("Order_Currency")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderDeadlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_DeadlineDate");

                entity.Property(e => e.OrderDeliveryWays).HasColumnName("Order_DeliveryWays");

                entity.Property(e => e.OrderDepartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_DepartDate");

                entity.Property(e => e.OrderEclogisticsId).HasColumnName("Order_ECLogisticsID");

                entity.Property(e => e.OrderEcstoreCode).HasColumnName("Order_ECStoreCode");

                entity.Property(e => e.OrderFloatParamA).HasColumnName("Order_FloatParamA");

                entity.Property(e => e.OrderFloatParamB).HasColumnName("Order_FloatParamB");

                entity.Property(e => e.OrderInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_InsertDate");

                entity.Property(e => e.OrderIntParamA).HasColumnName("Order_IntParamA");

                entity.Property(e => e.OrderIntParamB).HasColumnName("Order_IntParamB");

                entity.Property(e => e.OrderMainStoreCode).HasColumnName("Order_MainStoreCode");

                entity.Property(e => e.OrderNote)
                    .HasColumnType("text")
                    .HasColumnName("Order_Note");

                entity.Property(e => e.OrderPayOrderTableNo).HasColumnName("Order_PayOrderTableNo");

                entity.Property(e => e.OrderPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_PaymentDate");

                entity.Property(e => e.OrderPlatChangeAmount).HasColumnName("Order_PlatChangeAmount");

                entity.Property(e => e.OrderQrcode)
                    .HasColumnType("text")
                    .HasColumnName("Order_QRCode");

                entity.Property(e => e.OrderRecAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Order_RecAddress")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderRecCity).HasColumnName("Order_RecCity");

                entity.Property(e => e.OrderRecCityArea).HasColumnName("Order_RecCityArea");

                entity.Property(e => e.OrderRecCountry).HasColumnName("Order_RecCountry");

                entity.Property(e => e.OrderRecEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Order_RecEmail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderRecName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Order_RecName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderRecTel)
                    .HasMaxLength(50)
                    .HasColumnName("Order_RecTel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderReceiptAmount).HasColumnName("Order_ReceiptAmount");

                entity.Property(e => e.OrderReceiptText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Order_ReceiptText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.OrderShippingAmount).HasColumnName("Order_ShippingAmount");

                entity.Property(e => e.OrderState).HasColumnName("Order_State");

                entity.Property(e => e.OrderTableNo).HasColumnName("Order_TableNo");

                entity.Property(e => e.OrderTaxRate).HasColumnName("Order_TaxRate");

                entity.Property(e => e.OrderType).HasColumnName("Order_Type");

                entity.Property(e => e.OrderUserInfoCode).HasColumnName("Order_UserInfoCode");

                entity.Property(e => e.OrderUserPointId).HasColumnName("Order_UserPointID");

                entity.Property(e => e.OrderVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Order_VarParamA");

                entity.Property(e => e.OrderVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Order_VarParamB");
            });

            modelBuilder.Entity<TerpPoint>(entity =>
            {
                entity.HasKey(e => e.PointId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_point");

                entity.HasIndex(e => new { e.PointTableNo, e.PointCategoryType, e.PointType }, "Index");

                entity.Property(e => e.PointId).HasColumnName("Point_ID");

                entity.Property(e => e.PointActiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Point_ActiveDate");

                entity.Property(e => e.PointAddQuantity).HasColumnName("Point_AddQuantity");

                entity.Property(e => e.PointCategoryType).HasColumnName("Point_CategoryType");

                entity.Property(e => e.PointFloatParamA).HasColumnName("Point_FloatParamA");

                entity.Property(e => e.PointFloatParamB).HasColumnName("Point_FloatParamB");

                entity.Property(e => e.PointInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Point_InsertDate");

                entity.Property(e => e.PointIntParamA).HasColumnName("Point_IntParamA");

                entity.Property(e => e.PointIntParamB).HasColumnName("Point_IntParamB");

                entity.Property(e => e.PointRunTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Point_RunTime")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PointState).HasColumnName("Point_State");

                entity.Property(e => e.PointSubText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Point_SubText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PointTableNo).HasColumnName("Point_TableNo");

                entity.Property(e => e.PointText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Point_Text")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PointType).HasColumnName("Point_Type");

                entity.Property(e => e.PointUseage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Point_Useage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PointUserAmount).HasColumnName("Point_UserAmount");

                entity.Property(e => e.PointValidState).HasColumnName("Point_ValidState");

                entity.Property(e => e.PointVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Point_VarParamA");

                entity.Property(e => e.PointVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Point_VarParamB");
            });

            modelBuilder.Entity<TerpPointpart>(entity =>
            {
                entity.HasKey(e => e.PointPartId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_pointpart");

                entity.HasIndex(e => new { e.PointPartPointTableNo, e.PointPartUserInfoCode }, "Index");

                entity.Property(e => e.PointPartId).HasColumnName("PointPart_ID");

                entity.Property(e => e.PointPartFloatParamA).HasColumnName("PointPart_FloatParamA");

                entity.Property(e => e.PointPartFloatParamB).HasColumnName("PointPart_FloatParamB");

                entity.Property(e => e.PointPartIntParamA).HasColumnName("PointPart_IntParamA");

                entity.Property(e => e.PointPartIntParamB).HasColumnName("PointPart_IntParamB");

                entity.Property(e => e.PointPartPointTableNo).HasColumnName("PointPart_PointTableNo");

                entity.Property(e => e.PointPartState).HasColumnName("PointPart_State");

                entity.Property(e => e.PointPartSyncState).HasColumnName("PointPart_SyncState");

                entity.Property(e => e.PointPartUserInfoCode).HasColumnName("PointPart_UserInfoCode");

                entity.Property(e => e.PointPartUserInfoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PointPart_UserInfoName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PointPartUserInfoUuid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PointPart_UserInfoUUID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PointPartUserState).HasColumnName("PointPart_UserState");

                entity.Property(e => e.PointPartValidState).HasColumnName("PointPart_ValidState");

                entity.Property(e => e.PointPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PointPart_VarParamA");

                entity.Property(e => e.PointPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PointPart_VarParamB");
            });

            modelBuilder.Entity<TerpRefund>(entity =>
            {
                entity.HasKey(e => e.RefundId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_refund");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.RefundTableNo, e.RefundPayOrderTableNo, e.RefundMainStoreCode, e.RefundEcstoreCode, e.RefundUserInfoCode }, "Index");

                entity.Property(e => e.RefundId).HasColumnName("Refund_ID");

                entity.Property(e => e.RefundCurrency)
                    .HasMaxLength(5)
                    .HasColumnName("Refund_Currency")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.RefundEcstoreCode).HasColumnName("Refund_ECStoreCode");

                entity.Property(e => e.RefundFloatParamA).HasColumnName("Refund_FloatParamA");

                entity.Property(e => e.RefundFloatParamB).HasColumnName("Refund_FloatParamB");

                entity.Property(e => e.RefundInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Refund_InsertDate");

                entity.Property(e => e.RefundIntParamA).HasColumnName("Refund_IntParamA");

                entity.Property(e => e.RefundIntParamB).HasColumnName("Refund_IntParamB");

                entity.Property(e => e.RefundMainStoreCode).HasColumnName("Refund_MainStoreCode");

                entity.Property(e => e.RefundPayOrderTableNo).HasColumnName("Refund_PayOrderTableNo");

                entity.Property(e => e.RefundRefundAmount).HasColumnName("Refund_RefundAmount");

                entity.Property(e => e.RefundRefundResult)
                    .HasColumnType("text")
                    .HasColumnName("Refund_RefundResult");

                entity.Property(e => e.RefundState).HasColumnName("Refund_State");

                entity.Property(e => e.RefundTableNo).HasColumnName("Refund_TableNo");

                entity.Property(e => e.RefundTaxRate).HasColumnName("Refund_TaxRate");

                entity.Property(e => e.RefundUserInfoCode).HasColumnName("Refund_UserInfoCode");

                entity.Property(e => e.RefundVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Refund_VarParamA");

                entity.Property(e => e.RefundVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Refund_VarParamB");
            });

            modelBuilder.Entity<TerpReturngood>(entity =>
            {
                entity.HasKey(e => e.ReturnGoodsId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_returngoods");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ReturnGoodsTableNo, e.ReturnGoodsEcstoreCode }, "Index");

                entity.Property(e => e.ReturnGoodsId).HasColumnName("ReturnGoods_ID");

                entity.Property(e => e.ReturnGoodsAddress)
                    .HasMaxLength(500)
                    .HasColumnName("ReturnGoods_Address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ReturnGoodsArrivalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ReturnGoods_ArrivalDate");

                entity.Property(e => e.ReturnGoodsCname)
                    .HasMaxLength(200)
                    .HasColumnName("ReturnGoods_CName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ReturnGoodsCphone)
                    .HasMaxLength(20)
                    .HasColumnName("ReturnGoods_CPhone")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ReturnGoodsEcstoreCode).HasColumnName("ReturnGoods_ECStoreCode");

                entity.Property(e => e.ReturnGoodsFloatParamA).HasColumnName("ReturnGoods_FloatParamA");

                entity.Property(e => e.ReturnGoodsFloatParamB).HasColumnName("ReturnGoods_FloatParamB");

                entity.Property(e => e.ReturnGoodsInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ReturnGoods_InsertDate");

                entity.Property(e => e.ReturnGoodsIntParamA).HasColumnName("ReturnGoods_IntParamA");

                entity.Property(e => e.ReturnGoodsIntParamB).HasColumnName("ReturnGoods_IntParamB");

                entity.Property(e => e.ReturnGoodsState).HasColumnName("ReturnGoods_State");

                entity.Property(e => e.ReturnGoodsTableNo).HasColumnName("ReturnGoods_TableNo");

                entity.Property(e => e.ReturnGoodsVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ReturnGoods_VarParamA");

                entity.Property(e => e.ReturnGoodsVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ReturnGoods_VarParamB");
            });

            modelBuilder.Entity<TerpService>(entity =>
            {
                entity.HasKey(e => e.ServicesId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_services");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ServicesTableNo, e.ServicesOrderTableNo, e.ServicesUserInfoCode, e.ServicesEcstoreCode }, "Index");

                entity.Property(e => e.ServicesId).HasColumnName("Services_ID");

                entity.Property(e => e.ServicesAddress)
                    .HasMaxLength(500)
                    .HasColumnName("Services_Address")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServicesCname)
                    .HasMaxLength(200)
                    .HasColumnName("Services_CName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServicesCphone)
                    .HasMaxLength(20)
                    .HasColumnName("Services_CPhone")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServicesEcstoreCode).HasColumnName("Services_ECStoreCode");

                entity.Property(e => e.ServicesEmail)
                    .HasMaxLength(500)
                    .HasColumnName("Services_Email")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServicesFloatParamA).HasColumnName("Services_FloatParamA");

                entity.Property(e => e.ServicesFloatParamB).HasColumnName("Services_FloatParamB");

                entity.Property(e => e.ServicesHandleState).HasColumnName("Services_HandleState");

                entity.Property(e => e.ServicesInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Services_InsertDate");

                entity.Property(e => e.ServicesIntParamA).HasColumnName("Services_IntParamA");

                entity.Property(e => e.ServicesIntParamB).HasColumnName("Services_IntParamB");

                entity.Property(e => e.ServicesOrderTableNo).HasColumnName("Services_OrderTableNo");

                entity.Property(e => e.ServicesOtherMsg)
                    .HasMaxLength(1000)
                    .HasColumnName("Services_OtherMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ServicesReason).HasColumnName("Services_Reason");

                entity.Property(e => e.ServicesState).HasColumnName("Services_State");

                entity.Property(e => e.ServicesTableNo).HasColumnName("Services_TableNo");

                entity.Property(e => e.ServicesUserInfoCode).HasColumnName("Services_UserInfoCode");

                entity.Property(e => e.ServicesVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Services_VarParamA");

                entity.Property(e => e.ServicesVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Services_VarParamB");
            });

            modelBuilder.Entity<TerpShipper>(entity =>
            {
                entity.HasKey(e => e.ShipperId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_shipper");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ShipperTableNo, e.ShipperEcstoreCode, e.ShipperEclogisticsId }, "Index");

                entity.Property(e => e.ShipperId).HasColumnName("Shipper_ID");

                entity.Property(e => e.ShipperArrivalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Shipper_ArrivalDate");

                entity.Property(e => e.ShipperAutoArrivalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Shipper_AutoArrivalDate");

                entity.Property(e => e.ShipperConsumerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Shipper_ConsumerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperDeliveryWays).HasColumnName("Shipper_DeliveryWays");

                entity.Property(e => e.ShipperEclogisticsId).HasColumnName("Shipper_ECLogisticsID");

                entity.Property(e => e.ShipperEcstoreCode).HasColumnName("Shipper_ECStoreCode");

                entity.Property(e => e.ShipperFloatParamA).HasColumnName("Shipper_FloatParamA");

                entity.Property(e => e.ShipperFloatParamB).HasColumnName("Shipper_FloatParamB");

                entity.Property(e => e.ShipperImage1)
                    .HasMaxLength(200)
                    .HasColumnName("Shipper_Image1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperImage2)
                    .HasMaxLength(200)
                    .HasColumnName("Shipper_Image2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperImage3)
                    .HasMaxLength(200)
                    .HasColumnName("Shipper_Image3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Shipper_InsertDate");

                entity.Property(e => e.ShipperIntParamA).HasColumnName("Shipper_IntParamA");

                entity.Property(e => e.ShipperIntParamB).HasColumnName("Shipper_IntParamB");

                entity.Property(e => e.ShipperRecAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Shipper_RecAddress")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperRecCity).HasColumnName("Shipper_RecCity");

                entity.Property(e => e.ShipperRecCityArea).HasColumnName("Shipper_RecCityArea");

                entity.Property(e => e.ShipperRecCountry).HasColumnName("Shipper_RecCountry");

                entity.Property(e => e.ShipperRecEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Shipper_RecEmail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperRecName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Shipper_RecName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperRecTel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Shipper_RecTel")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperShippingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Shipper_ShippingDate");

                entity.Property(e => e.ShipperShippingNo)
                    .HasMaxLength(200)
                    .HasColumnName("Shipper_ShippingNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ShipperState).HasColumnName("Shipper_State");

                entity.Property(e => e.ShipperTableNo).HasColumnName("Shipper_TableNo");

                entity.Property(e => e.ShipperVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Shipper_VarParamA");

                entity.Property(e => e.ShipperVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Shipper_VarParamB");

                entity.Property(e => e.ShipperVideoUrl)
                    .HasMaxLength(200)
                    .HasColumnName("Shipper_VideoURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TerpSubstore>(entity =>
            {
                entity.HasKey(e => e.SubStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_substore");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.SubStoreTableNo, e.SubStoreCompanyCode, e.SubStoreEcstoreCode }, "Index");

                entity.Property(e => e.SubStoreId).HasColumnName("SubStore_ID");

                entity.Property(e => e.SubStoreCompanyCode).HasColumnName("SubStore_CompanyCode");

                entity.Property(e => e.SubStoreEcstoreCode).HasColumnName("SubStore_ECStoreCode");

                entity.Property(e => e.SubStoreFloatParamA).HasColumnName("SubStore_FloatParamA");

                entity.Property(e => e.SubStoreFloatParamB).HasColumnName("SubStore_FloatParamB");

                entity.Property(e => e.SubStoreFloatParamC).HasColumnName("SubStore_FloatParamC");

                entity.Property(e => e.SubStoreInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SubStore_InsertDate");

                entity.Property(e => e.SubStoreIntParamA).HasColumnName("SubStore_IntParamA");

                entity.Property(e => e.SubStoreIntParamB).HasColumnName("SubStore_IntParamB");

                entity.Property(e => e.SubStoreIntParamC).HasColumnName("SubStore_IntParamC");

                entity.Property(e => e.SubStoreState).HasColumnName("SubStore_State");

                entity.Property(e => e.SubStoreTableNo).HasColumnName("SubStore_TableNo");

                entity.Property(e => e.SubStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("SubStore_VarParamA");

                entity.Property(e => e.SubStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("SubStore_VarParamB");

                entity.Property(e => e.SubStoreVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("SubStore_VarParamC");
            });

            modelBuilder.Entity<TerpVendingorder>(entity =>
            {
                entity.HasKey(e => e.VendingOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_vendingorder");

                entity.HasIndex(e => new { e.VendingOrderEcstoreCode, e.VendingOrderUserInfoCode, e.VendingOrderUserVoucherCode }, "Index");

                entity.Property(e => e.VendingOrderId).HasColumnName("VendingOrder_ID");

                entity.Property(e => e.VendingOrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VendingOrder_Date");

                entity.Property(e => e.VendingOrderEcstoreCode).HasColumnName("VendingOrder_ECStoreCode");

                entity.Property(e => e.VendingOrderExtGoodsId)
                    .HasMaxLength(100)
                    .HasColumnName("VendingOrder_ExtGoodsID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VendingOrderExtGoodsPrice)
                    .HasMaxLength(100)
                    .HasColumnName("VendingOrder_ExtGoodsPrice")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VendingOrderExtNo)
                    .HasMaxLength(100)
                    .HasColumnName("VendingOrder_ExtNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VendingOrderExtState).HasColumnName("VendingOrder_ExtState");

                entity.Property(e => e.VendingOrderFloatParamA).HasColumnName("VendingOrder_FloatParamA");

                entity.Property(e => e.VendingOrderFloatParamB).HasColumnName("VendingOrder_FloatParamB");

                entity.Property(e => e.VendingOrderIntParamA).HasColumnName("VendingOrder_IntParamA");

                entity.Property(e => e.VendingOrderIntParamB).HasColumnName("VendingOrder_IntParamB");

                entity.Property(e => e.VendingOrderLimitDate)
                    .HasMaxLength(100)
                    .HasColumnName("VendingOrder_LimitDate")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VendingOrderState).HasColumnName("VendingOrder_State");

                entity.Property(e => e.VendingOrderUserGroupNo).HasColumnName("VendingOrder_UserGroupNo");

                entity.Property(e => e.VendingOrderUserInfoCode).HasColumnName("VendingOrder_UserInfoCode");

                entity.Property(e => e.VendingOrderUserVoucherCode).HasColumnName("VendingOrder_UserVoucherCode");

                entity.Property(e => e.VendingOrderVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VendingOrder_VarParamA");

                entity.Property(e => e.VendingOrderVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VendingOrder_VarParamB");
            });

            modelBuilder.Entity<TerpVouapply>(entity =>
            {
                entity.HasKey(e => e.VouApplyId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_vouapply");

                entity.HasIndex(e => new { e.VouApplyTableNo, e.VouApplyCategoryType }, "Index");

                entity.Property(e => e.VouApplyId).HasColumnName("VouApply_ID");

                entity.Property(e => e.VouApplyActiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VouApply_ActiveDate");

                entity.Property(e => e.VouApplyCategoryType).HasColumnName("VouApply_CategoryType");

                entity.Property(e => e.VouApplyFloatParamA).HasColumnName("VouApply_FloatParamA");

                entity.Property(e => e.VouApplyFloatParamB).HasColumnName("VouApply_FloatParamB");

                entity.Property(e => e.VouApplyInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VouApply_InsertDate");

                entity.Property(e => e.VouApplyIntParamA).HasColumnName("VouApply_IntParamA");

                entity.Property(e => e.VouApplyIntParamB).HasColumnName("VouApply_IntParamB");

                entity.Property(e => e.VouApplyRunTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VouApply_RunTime")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouApplyState).HasColumnName("VouApply_State");

                entity.Property(e => e.VouApplyTableNo).HasColumnName("VouApply_TableNo");

                entity.Property(e => e.VouApplyUseage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("VouApply_Useage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouApplyUserAmount).HasColumnName("VouApply_UserAmount");

                entity.Property(e => e.VouApplyValidState).HasColumnName("VouApply_ValidState");

                entity.Property(e => e.VouApplyVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VouApply_VarParamA");

                entity.Property(e => e.VouApplyVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VouApply_VarParamB");

                entity.Property(e => e.VouApplyVouAmount).HasColumnName("VouApply_VouAmount");
            });

            modelBuilder.Entity<TerpVouapplypart>(entity =>
            {
                entity.HasKey(e => e.VouApplyPartId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_vouapplypart");

                entity.HasIndex(e => new { e.VouApplyPartTableNo, e.VouApplyPartVoucherCode }, "Index");

                entity.Property(e => e.VouApplyPartId).HasColumnName("VouApplyPart_ID");

                entity.Property(e => e.VouApplyPartFloatParamA).HasColumnName("VouApplyPart_FloatParamA");

                entity.Property(e => e.VouApplyPartFloatParamB).HasColumnName("VouApplyPart_FloatParamB");

                entity.Property(e => e.VouApplyPartIntParamA).HasColumnName("VouApplyPart_IntParamA");

                entity.Property(e => e.VouApplyPartIntParamB).HasColumnName("VouApplyPart_IntParamB");

                entity.Property(e => e.VouApplyPartState).HasColumnName("VouApplyPart_State");

                entity.Property(e => e.VouApplyPartSyncState).HasColumnName("VouApplyPart_SyncState");

                entity.Property(e => e.VouApplyPartTableNo).HasColumnName("VouApplyPart_TableNo");

                entity.Property(e => e.VouApplyPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VouApplyPart_VarParamA");

                entity.Property(e => e.VouApplyPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VouApplyPart_VarParamB");

                entity.Property(e => e.VouApplyPartVoucherCode).HasColumnName("VouApplyPart_VoucherCode");
            });

            modelBuilder.Entity<TerpVreimburse>(entity =>
            {
                entity.HasKey(e => e.VreimburseId)
                    .HasName("PRIMARY");

                entity.ToTable("terp_vreimburse");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.VreimburseTableNo, "Index");

                entity.Property(e => e.VreimburseId).HasColumnName("VReimburse_ID");

                entity.Property(e => e.VreimburseAmount).HasColumnName("VReimburse_Amount");

                entity.Property(e => e.VreimburseCheckoutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VReimburse_CheckoutDate");

                entity.Property(e => e.VreimburseComGroupNo).HasColumnName("VReimburse_ComGroupNo");

                entity.Property(e => e.VreimburseDownloadDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VReimburse_DownloadDate");

                entity.Property(e => e.VreimburseExpTransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VReimburse_ExpTransferDate");

                entity.Property(e => e.VreimburseFloatParamA).HasColumnName("VReimburse_FloatParamA");

                entity.Property(e => e.VreimburseFloatParamB).HasColumnName("VReimburse_FloatParamB");

                entity.Property(e => e.VreimburseFloatParamC).HasColumnName("VReimburse_FloatParamC");

                entity.Property(e => e.VreimburseInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VReimburse_InsertDate");

                entity.Property(e => e.VreimburseIntParamA).HasColumnName("VReimburse_IntParamA");

                entity.Property(e => e.VreimburseIntParamB).HasColumnName("VReimburse_IntParamB");

                entity.Property(e => e.VreimburseIntParamC).HasColumnName("VReimburse_IntParamC");

                entity.Property(e => e.VreimburseInvDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VReimburse_InvDate");

                entity.Property(e => e.VreimburseInvImg)
                    .HasMaxLength(300)
                    .HasColumnName("VReimburse_InvImg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VreimburseInvoice)
                    .HasMaxLength(20)
                    .HasColumnName("VReimburse_Invoice")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VreimburseIsTransferFile).HasColumnName("VReimburse_IsTransferFile");

                entity.Property(e => e.VreimburseNoTax).HasColumnName("VReimburse_NoTax");

                entity.Property(e => e.VreimbursePayInfo)
                    .HasMaxLength(500)
                    .HasColumnName("VReimburse_PayInfo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VreimbursePayType).HasColumnName("VReimburse_PayType");

                entity.Property(e => e.VreimburseRemitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VReimburse_RemitDate");

                entity.Property(e => e.VreimburseRemitFile)
                    .HasMaxLength(500)
                    .HasColumnName("VReimburse_RemitFile")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VreimburseRemitImg)
                    .HasMaxLength(300)
                    .HasColumnName("VReimburse_RemitImg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VreimburseState).HasColumnName("VReimburse_State");

                entity.Property(e => e.VreimburseTableNo).HasColumnName("VReimburse_TableNo");

                entity.Property(e => e.VreimburseTax).HasColumnName("VReimburse_Tax");

                entity.Property(e => e.VreimburseTradeCommit).HasColumnName("VReimburse_TradeCommit");

                entity.Property(e => e.VreimburseVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VReimburse_VarParamA");

                entity.Property(e => e.VreimburseVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VReimburse_VarParamB");

                entity.Property(e => e.VreimburseVarParamC)
                    .HasColumnType("text")
                    .HasColumnName("VReimburse_VarParamC");
            });

            modelBuilder.Entity<TjskUsereventfile>(entity =>
            {
                entity.HasKey(e => e.UserEventFileId)
                    .HasName("PRIMARY");

                entity.ToTable("tjsk_usereventfile");

                entity.HasComment("使用者檔案審核記錄表(行銷活動)");

                entity.HasIndex(e => e.UserEventFileUserInfoCode, "tjsk_usereventfile_idx01");

                entity.Property(e => e.UserEventFileId)
                    .HasMaxLength(36)
                    .HasColumnName("UserEventFile_ID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileCrtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserEventFile_CrtDate");

                entity.Property(e => e.UserEventFileCrtName)
                    .HasMaxLength(30)
                    .HasColumnName("UserEventFile_CrtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileCrtUid)
                    .HasMaxLength(50)
                    .HasColumnName("UserEventFile_CrtUid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileFileSettingsId)
                    .HasColumnName("UserEventFile_FileSettingsID")
                    .HasComment("檔案編號");

                entity.Property(e => e.UserEventFileMdyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserEventFile_MdyDate");

                entity.Property(e => e.UserEventFileMdyName)
                    .HasMaxLength(30)
                    .HasColumnName("UserEventFile_MdyName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileMdyUid)
                    .HasMaxLength(50)
                    .HasColumnName("UserEventFile_MdyUid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileNote)
                    .HasColumnType("text")
                    .HasColumnName("UserEventFile_Note");

                entity.Property(e => e.UserEventFileType)
                    .HasColumnName("UserEventFile_Type")
                    .HasComment("檔案類型，參照UserFavourite_Number1(type=4)");

                entity.Property(e => e.UserEventFileUserInfoCode)
                    .HasColumnName("UserEventFile_UserInfoCode")
                    .HasComment("會員編號");

                entity.Property(e => e.UserEventFileVerifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserEventFile_VerifyDate")
                    .HasComment("審核時間");

                entity.Property(e => e.UserEventFileVerifyName)
                    .HasMaxLength(30)
                    .HasColumnName("UserEventFile_VerifyName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileVerifyStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserEventFile_VerifyStatus")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserEventFileVerifyUid)
                    .HasMaxLength(50)
                    .HasColumnName("UserEventFile_VerifyUid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TjskUsertag>(entity =>
            {
                entity.HasKey(e => new { e.UserTagUserInfoCode, e.UserTagName })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("tjsk_usertag");

                entity.HasComment("使用者標籤資料表(貼標)");

                entity.HasIndex(e => new { e.UserTagUserInfoCode, e.UserTagCrtUid, e.UserTagMdyUid }, "Index");

                entity.Property(e => e.UserTagUserInfoCode).HasColumnName("UserTag_UserInfoCode");

                entity.Property(e => e.UserTagName)
                    .HasMaxLength(30)
                    .HasColumnName("UserTag_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTagCrtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTag_CrtDate");

                entity.Property(e => e.UserTagCrtName)
                    .HasMaxLength(30)
                    .HasColumnName("UserTag_CrtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTagCrtUid)
                    .HasMaxLength(50)
                    .HasColumnName("UserTag_CrtUid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTagMdyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserTag_MdyDate");

                entity.Property(e => e.UserTagMdyName)
                    .HasMaxLength(30)
                    .HasColumnName("UserTag_MdyName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserTagMdyUid)
                    .HasMaxLength(50)
                    .HasColumnName("UserTag_MdyUid")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TpayContractstore>(entity =>
            {
                entity.HasKey(e => e.ContractStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_contractstore");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ContractStoreId).HasColumnName("ContractStore_ID");

                entity.Property(e => e.ContractStoreAccount)
                    .HasMaxLength(20)
                    .HasColumnName("ContractStore_Account")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreAgreedDay).HasColumnName("ContractStore_AgreedDay");

                entity.Property(e => e.ContractStoreBackUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ContractStore_BackURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreBusinessType).HasColumnName("ContractStore_BusinessType");

                entity.Property(e => e.ContractStoreCityE).HasColumnName("ContractStore_CityE");

                entity.Property(e => e.ContractStoreCode).HasColumnName("ContractStore_Code");

                entity.Property(e => e.ContractStoreCompanyCode).HasColumnName("ContractStore_CompanyCode");

                entity.Property(e => e.ContractStoreCountry).HasColumnName("ContractStore_Country");

                entity.Property(e => e.ContractStoreCountryCode).HasColumnName("ContractStore_CountryCode");

                entity.Property(e => e.ContractStoreCreditLimit).HasColumnName("ContractStore_CreditLimit");

                entity.Property(e => e.ContractStoreFloatParamA).HasColumnName("ContractStore_FloatParamA");

                entity.Property(e => e.ContractStoreFloatParamB).HasColumnName("ContractStore_FloatParamB");

                entity.Property(e => e.ContractStoreFrontUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ContractStore_FrontURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreHashIv)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_HashIV")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreHashKey)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_HashKey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreIdcardDate)
                    .HasMaxLength(10)
                    .HasColumnName("ContractStore_IDCardDate")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreIdcardPlace)
                    .HasMaxLength(10)
                    .HasColumnName("ContractStore_IDCardPlace")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreIdfrom).HasColumnName("ContractStore_IDFrom");

                entity.Property(e => e.ContractStoreIdno)
                    .HasMaxLength(50)
                    .HasColumnName("ContractStore_IDNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreIdpic).HasColumnName("ContractStore_IDPic");

                entity.Property(e => e.ContractStoreIntParamA).HasColumnName("ContractStore_IntParamA");

                entity.Property(e => e.ContractStoreIntParamB).HasColumnName("ContractStore_IntParamB");

                entity.Property(e => e.ContractStoreInvoiceHashIv)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_InvoiceHashIV")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreInvoiceHashKey)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_InvoiceHashKey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreInvoiceMerchantId)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_InvoiceMerchantID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreInvoiceSupplier).HasColumnName("ContractStore_InvoiceSupplier");

                entity.Property(e => e.ContractStoreIsOpen).HasColumnName("ContractStore_IsOpen");

                entity.Property(e => e.ContractStoreMerchantCode)
                    .HasMaxLength(15)
                    .HasColumnName("ContractStore_MerchantCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreMerchantDesc)
                    .HasMaxLength(255)
                    .HasColumnName("ContractStore_MerchantDesc")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreMerchantId)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_MerchantID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreMerchantType).HasColumnName("ContractStore_MerchantType");

                entity.Property(e => e.ContractStoreName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ContractStore_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreNationalE).HasColumnName("ContractStore_NationalE");

                entity.Property(e => e.ContractStorePaymentFlowCode).HasColumnName("ContractStore_PaymentFlowCode");

                entity.Property(e => e.ContractStoreResultUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ContractStore_ResultURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreState).HasColumnName("ContractStore_State");

                entity.Property(e => e.ContractStoreSyncState).HasColumnName("ContractStore_SyncState");

                entity.Property(e => e.ContractStoreTerminalId)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_TerminalID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreTranPwd)
                    .HasMaxLength(100)
                    .HasColumnName("ContractStore_TranPWD")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ContractStoreType).HasColumnName("ContractStore_Type");

                entity.Property(e => e.ContractStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ContractStore_VarParamA");

                entity.Property(e => e.ContractStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ContractStore_VarParamB");

                entity.Property(e => e.ContractStoreWithdraw).HasColumnName("ContractStore_Withdraw");

                entity.Property(e => e.ContractStoreWithdrawMer).HasColumnName("ContractStore_WithdrawMer");

                entity.Property(e => e.ContractStoreWithdrawSetting)
                    .HasMaxLength(10)
                    .HasColumnName("ContractStore_WithdrawSetting")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TpayCspayment>(entity =>
            {
                entity.HasKey(e => e.CspaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_cspayment");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CspaymentId).HasColumnName("CSPayment_ID");

                entity.Property(e => e.CspaymentCompanyCode).HasColumnName("CSPayment_CompanyCode");

                entity.Property(e => e.CspaymentContractStoreCode).HasColumnName("CSPayment_ContractStoreCode");

                entity.Property(e => e.CspaymentFloatParamA).HasColumnName("CSPayment_FloatParamA");

                entity.Property(e => e.CspaymentFloatParamB).HasColumnName("CSPayment_FloatParamB");

                entity.Property(e => e.CspaymentImage)
                    .HasMaxLength(200)
                    .HasColumnName("CSPayment_Image")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CspaymentIntParamA).HasColumnName("CSPayment_IntParamA");

                entity.Property(e => e.CspaymentIntParamB).HasColumnName("CSPayment_IntParamB");

                entity.Property(e => e.CspaymentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CSPayment_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CspaymentPayType).HasColumnName("CSPayment_PayType");

                entity.Property(e => e.CspaymentPfpaymentCode).HasColumnName("CSPayment_PFPaymentCode");

                entity.Property(e => e.CspaymentRefundCount).HasColumnName("CSPayment_RefundCount");

                entity.Property(e => e.CspaymentShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CSPayment_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CspaymentSort).HasColumnName("CSPayment_Sort");

                entity.Property(e => e.CspaymentState).HasColumnName("CSPayment_State");

                entity.Property(e => e.CspaymentSyncState).HasColumnName("CSPayment_SyncState");

                entity.Property(e => e.CspaymentVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("CSPayment_VarParamA");

                entity.Property(e => e.CspaymentVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("CSPayment_VarParamB");
            });

            modelBuilder.Entity<TpayCspaymentpart>(entity =>
            {
                entity.HasKey(e => e.CspaymentPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_cspaymentpart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CspaymentPartId).HasColumnName("CSPaymentPart_ID");

                entity.Property(e => e.CspaymentPartCspaymentId).HasColumnName("CSPaymentPart_CSPaymentID");

                entity.Property(e => e.CspaymentPartFee).HasColumnName("CSPaymentPart_Fee");

                entity.Property(e => e.CspaymentPartFeeType).HasColumnName("CSPaymentPart_FeeType");

                entity.Property(e => e.CspaymentPartFloatParamA).HasColumnName("CSPaymentPart_FloatParamA");

                entity.Property(e => e.CspaymentPartFloatParamB).HasColumnName("CSPaymentPart_FloatParamB");

                entity.Property(e => e.CspaymentPartIntParamA).HasColumnName("CSPaymentPart_IntParamA");

                entity.Property(e => e.CspaymentPartIntParamB).HasColumnName("CSPaymentPart_IntParamB");

                entity.Property(e => e.CspaymentPartMaxFee).HasColumnName("CSPaymentPart_MaxFee");

                entity.Property(e => e.CspaymentPartMinFee).HasColumnName("CSPaymentPart_MinFee");

                entity.Property(e => e.CspaymentPartName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CSPaymentPart_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CspaymentPartPfpaymentPartCode).HasColumnName("CSPaymentPart_PFPaymentPartCode");

                entity.Property(e => e.CspaymentPartShowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CSPaymentPart_ShowName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CspaymentPartState).HasColumnName("CSPaymentPart_State");

                entity.Property(e => e.CspaymentPartSyncState).HasColumnName("CSPaymentPart_SyncState");

                entity.Property(e => e.CspaymentPartValue).HasColumnName("CSPaymentPart_Value");

                entity.Property(e => e.CspaymentPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("CSPaymentPart_VarParamA");

                entity.Property(e => e.CspaymentPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("CSPaymentPart_VarParamB");
            });

            modelBuilder.Entity<TpayInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_invoice");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.InvoiceAllowanceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_AllowanceDate");

                entity.Property(e => e.InvoiceAllowanceImage)
                    .HasMaxLength(100)
                    .HasColumnName("Invoice_AllowanceImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceAllowanceNo)
                    .HasMaxLength(100)
                    .HasColumnName("Invoice_AllowanceNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceAllowancePrice).HasColumnName("Invoice_AllowancePrice");

                entity.Property(e => e.InvoiceClass).HasColumnName("Invoice_Class");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_Date");

                entity.Property(e => e.InvoiceFinanceCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_FinanceCheckDate");

                entity.Property(e => e.InvoiceFinanceCode).HasColumnName("Invoice_FinanceCode");

                entity.Property(e => e.InvoiceFloatParamA).HasColumnName("Invoice_FloatParamA");

                entity.Property(e => e.InvoiceFloatParamB).HasColumnName("Invoice_FloatParamB");

                entity.Property(e => e.InvoiceHandleState).HasColumnName("Invoice_HandleState");

                entity.Property(e => e.InvoiceInsertMode).HasColumnName("Invoice_InsertMode");

                entity.Property(e => e.InvoiceIntParamA).HasColumnName("Invoice_IntParamA");

                entity.Property(e => e.InvoiceIntParamB).HasColumnName("Invoice_IntParamB");

                entity.Property(e => e.InvoiceInvalidChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_InvalidChangeDate");

                entity.Property(e => e.InvoiceInvalidDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_InvalidDate");

                entity.Property(e => e.InvoiceInvalidText)
                    .HasMaxLength(200)
                    .HasColumnName("Invoice_InvalidText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice_InvoiceDate");

                entity.Property(e => e.InvoiceInvoiceImage)
                    .HasMaxLength(100)
                    .HasColumnName("Invoice_InvoiceImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceMode).HasColumnName("Invoice_Mode");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Invoice_No")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoicePayOrderExtNo)
                    .HasMaxLength(30)
                    .HasColumnName("Invoice_PayOrderExtNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoicePayOrderTableNo).HasColumnName("Invoice_PayOrderTableNo");

                entity.Property(e => e.InvoicePrice).HasColumnName("Invoice_Price");

                entity.Property(e => e.InvoiceRanCode)
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_RanCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceRegisterNo)
                    .HasMaxLength(20)
                    .HasColumnName("Invoice_RegisterNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceState).HasColumnName("Invoice_State");

                entity.Property(e => e.InvoiceTaxType).HasColumnName("Invoice_TaxType");

                entity.Property(e => e.InvoiceTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Invoice_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoiceType).HasColumnName("Invoice_Type");

                entity.Property(e => e.InvoiceVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Invoice_VarParamA");

                entity.Property(e => e.InvoiceVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Invoice_VarParamB");

                entity.Property(e => e.InvoiceVreimburseTableNo).HasColumnName("Invoice_VReimburseTableNo");
            });

            modelBuilder.Entity<TpayInvoicepart>(entity =>
            {
                entity.HasKey(e => e.InvoicePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_invoicepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InvoicePartId).HasColumnName("InvoicePart_ID");

                entity.Property(e => e.InvoicePartAllowancePrice).HasColumnName("InvoicePart_AllowancePrice");

                entity.Property(e => e.InvoicePartAmt).HasColumnName("InvoicePart_Amt");

                entity.Property(e => e.InvoicePartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("InvoicePart_Date");

                entity.Property(e => e.InvoicePartFloatParamA).HasColumnName("InvoicePart_FloatParamA");

                entity.Property(e => e.InvoicePartFloatParamB).HasColumnName("InvoicePart_FloatParamB");

                entity.Property(e => e.InvoicePartIntParamA).HasColumnName("InvoicePart_IntParamA");

                entity.Property(e => e.InvoicePartIntParamB).HasColumnName("InvoicePart_IntParamB");

                entity.Property(e => e.InvoicePartInvoiceId).HasColumnName("InvoicePart_InvoiceID");

                entity.Property(e => e.InvoicePartItemCode).HasColumnName("InvoicePart_ItemCode");

                entity.Property(e => e.InvoicePartItemName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("InvoicePart_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.InvoicePartNoTaxPrice).HasColumnName("InvoicePart_NoTaxPrice");

                entity.Property(e => e.InvoicePartPrice).HasColumnName("InvoicePart_Price");

                entity.Property(e => e.InvoicePartQty).HasColumnName("InvoicePart_QTY");

                entity.Property(e => e.InvoicePartState).HasColumnName("InvoicePart_State");

                entity.Property(e => e.InvoicePartTax).HasColumnName("InvoicePart_Tax");

                entity.Property(e => e.InvoicePartUnit).HasColumnName("InvoicePart_Unit");

                entity.Property(e => e.InvoicePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("InvoicePart_VarParamA");

                entity.Property(e => e.InvoicePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("InvoicePart_VarParamB");
            });

            modelBuilder.Entity<TpayPaymentflow>(entity =>
            {
                entity.HasKey(e => e.PaymentFlowId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_paymentflow");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaymentFlowId).HasColumnName("PaymentFlow_ID");

                entity.Property(e => e.PaymentFlowCode).HasColumnName("PaymentFlow_Code");

                entity.Property(e => e.PaymentFlowCountryCode).HasColumnName("PaymentFlow_CountryCode");

                entity.Property(e => e.PaymentFlowFloatParamA).HasColumnName("PaymentFlow_FloatParamA");

                entity.Property(e => e.PaymentFlowFloatParamB).HasColumnName("PaymentFlow_FloatParamB");

                entity.Property(e => e.PaymentFlowIntParamA).HasColumnName("PaymentFlow_IntParamA");

                entity.Property(e => e.PaymentFlowIntParamB).HasColumnName("PaymentFlow_IntParamB");

                entity.Property(e => e.PaymentFlowName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PaymentFlow_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PaymentFlowState).HasColumnName("PaymentFlow_State");

                entity.Property(e => e.PaymentFlowSyncState).HasColumnName("PaymentFlow_SyncState");

                entity.Property(e => e.PaymentFlowVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PaymentFlow_VarParamA");

                entity.Property(e => e.PaymentFlowVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PaymentFlow_VarParamB");
            });

            modelBuilder.Entity<TpayPayorder>(entity =>
            {
                entity.HasKey(e => e.PayOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_payorder");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PayOrderId).HasColumnName("PayOrder_ID");

                entity.Property(e => e.PayOrderAlertCount).HasColumnName("PayOrder_AlertCount");

                entity.Property(e => e.PayOrderAllocateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_AllocateDate");

                entity.Property(e => e.PayOrderAllocateState).HasColumnName("PayOrder_AllocateState");

                entity.Property(e => e.PayOrderAmount).HasColumnName("PayOrder_Amount");

                entity.Property(e => e.PayOrderCancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_CancelDate");

                entity.Property(e => e.PayOrderCancelState).HasColumnName("PayOrder_CancelState");

                entity.Property(e => e.PayOrderCard4No)
                    .HasMaxLength(4)
                    .HasColumnName("PayOrder_Card4No")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderCarrierCode)
                    .HasMaxLength(20)
                    .HasColumnName("PayOrder_CarrierCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderCarrierType).HasColumnName("PayOrder_CarrierType");

                entity.Property(e => e.PayOrderClearDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_ClearDate");

                entity.Property(e => e.PayOrderClearState).HasColumnName("PayOrder_ClearState");

                entity.Property(e => e.PayOrderContractStoreCode).HasColumnName("PayOrder_ContractStoreCode");

                entity.Property(e => e.PayOrderCost).HasColumnName("PayOrder_Cost");

                entity.Property(e => e.PayOrderCurrency)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("PayOrder_Currency")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderEcstoreCode).HasColumnName("PayOrder_ECStoreCode");

                entity.Property(e => e.PayOrderExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_Expiry");

                entity.Property(e => e.PayOrderExtMemberId)
                    .HasMaxLength(64)
                    .HasColumnName("PayOrder_ExtMemberID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderExtNo)
                    .HasMaxLength(50)
                    .HasColumnName("PayOrder_ExtNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderExtraFee).HasColumnName("PayOrder_ExtraFee");

                entity.Property(e => e.PayOrderExtraFeeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_ExtraFeeDate");

                entity.Property(e => e.PayOrderExtraFeeState).HasColumnName("PayOrder_ExtraFeeState");

                entity.Property(e => e.PayOrderFloatParamA).HasColumnName("PayOrder_FloatParamA");

                entity.Property(e => e.PayOrderFloatParamB).HasColumnName("PayOrder_FloatParamB");

                entity.Property(e => e.PayOrderFundsMode).HasColumnName("PayOrder_FundsMode");

                entity.Property(e => e.PayOrderInfo)
                    .HasMaxLength(200)
                    .HasColumnName("PayOrder_Info")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_InsertDate");

                entity.Property(e => e.PayOrderIntParamA).HasColumnName("PayOrder_IntParamA");

                entity.Property(e => e.PayOrderIntParamB).HasColumnName("PayOrder_IntParamB");

                entity.Property(e => e.PayOrderInvoiceAddress)
                    .HasMaxLength(200)
                    .HasColumnName("PayOrder_InvoiceAddress")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderInvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_InvoiceDate");

                entity.Property(e => e.PayOrderInvoiceMode).HasColumnName("PayOrder_InvoiceMode");

                entity.Property(e => e.PayOrderInvoiceNo)
                    .HasMaxLength(30)
                    .HasColumnName("PayOrder_InvoiceNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderInvoiceRandom)
                    .HasMaxLength(10)
                    .HasColumnName("PayOrder_InvoiceRandom")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderInvoiceState).HasColumnName("PayOrder_InvoiceState");

                entity.Property(e => e.PayOrderInvoiceStatus).HasColumnName("PayOrder_InvoiceStatus");

                entity.Property(e => e.PayOrderInvoiceTaxId)
                    .HasMaxLength(10)
                    .HasColumnName("PayOrder_InvoiceTaxID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderInvoiceTitle)
                    .HasMaxLength(50)
                    .HasColumnName("PayOrder_InvoiceTitle")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderInvoiceType)
                    .HasMaxLength(10)
                    .HasColumnName("PayOrder_InvoiceType")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderLoveCode)
                    .HasMaxLength(20)
                    .HasColumnName("PayOrder_LoveCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderMainStoreCode).HasColumnName("PayOrder_MainStoreCode");

                entity.Property(e => e.PayOrderMemberEmail)
                    .HasMaxLength(64)
                    .HasColumnName("PayOrder_MemberEmail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderMemberName)
                    .HasMaxLength(30)
                    .HasColumnName("PayOrder_MemberName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderMemberPhone)
                    .HasMaxLength(20)
                    .HasColumnName("PayOrder_MemberPhone")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderMemo)
                    .HasColumnType("text")
                    .HasColumnName("PayOrder_Memo");

                entity.Property(e => e.PayOrderMobiiFee).HasColumnName("PayOrder_MobiiFee");

                entity.Property(e => e.PayOrderPayAmount).HasColumnName("PayOrder_PayAmount");

                entity.Property(e => e.PayOrderPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_PayDate");

                entity.Property(e => e.PayOrderPayState).HasColumnName("PayOrder_PayState");

                entity.Property(e => e.PayOrderPayUrl)
                    .HasMaxLength(500)
                    .HasColumnName("PayOrder_PayURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderPaymentFlowCode).HasColumnName("PayOrder_PaymentFlowCode");

                entity.Property(e => e.PayOrderPaymentNo)
                    .HasMaxLength(50)
                    .HasColumnName("PayOrder_PaymentNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderPaymentResult)
                    .HasColumnType("text")
                    .HasColumnName("PayOrder_PaymentResult");

                entity.Property(e => e.PayOrderPfpaymentCode).HasColumnName("PayOrder_PFPaymentCode");

                entity.Property(e => e.PayOrderPfpaymentPartCode).HasColumnName("PayOrder_PFPaymentPartCode");

                entity.Property(e => e.PayOrderPfpaymentPartValue)
                    .HasMaxLength(50)
                    .HasColumnName("PayOrder_PFPaymentPartValue")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderReceiptAmount).HasColumnName("PayOrder_ReceiptAmount");

                entity.Property(e => e.PayOrderReceiptNo)
                    .HasMaxLength(30)
                    .HasColumnName("PayOrder_ReceiptNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderRefundAmount).HasColumnName("PayOrder_RefundAmount");

                entity.Property(e => e.PayOrderRefundCount).HasColumnName("PayOrder_RefundCount");

                entity.Property(e => e.PayOrderRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_RefundDate");

                entity.Property(e => e.PayOrderRefundState).HasColumnName("PayOrder_RefundState");

                entity.Property(e => e.PayOrderRequestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_RequestDate");

                entity.Property(e => e.PayOrderRequestState).HasColumnName("PayOrder_RequestState");

                entity.Property(e => e.PayOrderResultUrl)
                    .HasMaxLength(500)
                    .HasColumnName("PayOrder_ResultURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderShippingAmount).HasColumnName("PayOrder_ShippingAmount");

                entity.Property(e => e.PayOrderState).HasColumnName("PayOrder_State");

                entity.Property(e => e.PayOrderSupplierPayUrl)
                    .HasMaxLength(500)
                    .HasColumnName("PayOrder_SupplierPayURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderTableNo).HasColumnName("PayOrder_TableNo");

                entity.Property(e => e.PayOrderTableNote)
                    .HasMaxLength(256)
                    .HasColumnName("PayOrder_TableNote")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderTrueAmount).HasColumnName("PayOrder_TrueAmount");

                entity.Property(e => e.PayOrderType).HasColumnName("PayOrder_Type");

                entity.Property(e => e.PayOrderUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrder_UpdateDate");

                entity.Property(e => e.PayOrderUserDeviceCode).HasColumnName("PayOrder_UserDeviceCode");

                entity.Property(e => e.PayOrderUserInfoCode).HasColumnName("PayOrder_UserInfoCode");

                entity.Property(e => e.PayOrderVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PayOrder_VarParamA");

                entity.Property(e => e.PayOrderVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PayOrder_VarParamB");
            });

            modelBuilder.Entity<TpayPayorderlog>(entity =>
            {
                entity.HasKey(e => e.PayOrderLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_payorderlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PayOrderLogId).HasColumnName("PayOrderLog_ID");

                entity.Property(e => e.PayOrderLogAmount).HasColumnName("PayOrderLog_Amount");

                entity.Property(e => e.PayOrderLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PayOrderLog_Date");

                entity.Property(e => e.PayOrderLogDealerName)
                    .HasMaxLength(30)
                    .HasColumnName("PayOrderLog_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PayOrderLogEcstoreCode).HasColumnName("PayOrderLog_ECStoreCode");

                entity.Property(e => e.PayOrderLogFloatParamA).HasColumnName("PayOrderLog_FloatParamA");

                entity.Property(e => e.PayOrderLogFloatParamB).HasColumnName("PayOrderLog_FloatParamB");

                entity.Property(e => e.PayOrderLogIntParamA).HasColumnName("PayOrderLog_IntParamA");

                entity.Property(e => e.PayOrderLogIntParamB).HasColumnName("PayOrderLog_IntParamB");

                entity.Property(e => e.PayOrderLogOrderTableNo).HasColumnName("PayOrderLog_OrderTableNo");

                entity.Property(e => e.PayOrderLogPayActionState).HasColumnName("PayOrderLog_PayActionState");

                entity.Property(e => e.PayOrderLogPayOrderTableNo).HasColumnName("PayOrderLog_PayOrderTableNo");

                entity.Property(e => e.PayOrderLogPaymentResult)
                    .HasColumnType("text")
                    .HasColumnName("PayOrderLog_PaymentResult");

                entity.Property(e => e.PayOrderLogRefundAmount).HasColumnName("PayOrderLog_RefundAmount");

                entity.Property(e => e.PayOrderLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PayOrderLog_VarParamA");

                entity.Property(e => e.PayOrderLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PayOrderLog_VarParamB");
            });

            modelBuilder.Entity<TpayPfpayment>(entity =>
            {
                entity.HasKey(e => e.PfpaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_pfpayment");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PfpaymentId).HasColumnName("PFPayment_ID");

                entity.Property(e => e.PfpaymentCode).HasColumnName("PFPayment_Code");

                entity.Property(e => e.PfpaymentFloatParamA).HasColumnName("PFPayment_FloatParamA");

                entity.Property(e => e.PfpaymentFloatParamB).HasColumnName("PFPayment_FloatParamB");

                entity.Property(e => e.PfpaymentIntParamA).HasColumnName("PFPayment_IntParamA");

                entity.Property(e => e.PfpaymentIntParamB).HasColumnName("PFPayment_IntParamB");

                entity.Property(e => e.PfpaymentMethod).HasColumnName("PFPayment_Method");

                entity.Property(e => e.PfpaymentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PFPayment_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PfpaymentPayType).HasColumnName("PFPayment_PayType");

                entity.Property(e => e.PfpaymentPaymentFlowCode).HasColumnName("PFPayment_PaymentFlowCode");

                entity.Property(e => e.PfpaymentRefundCount).HasColumnName("PFPayment_RefundCount");

                entity.Property(e => e.PfpaymentState).HasColumnName("PFPayment_State");

                entity.Property(e => e.PfpaymentSyncState).HasColumnName("PFPayment_SyncState");

                entity.Property(e => e.PfpaymentUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PFPayment_Url")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PfpaymentVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PFPayment_VarParamA");

                entity.Property(e => e.PfpaymentVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PFPayment_VarParamB");

                entity.Property(e => e.PfpaymenttSort).HasColumnName("PFPaymentt_Sort");
            });

            modelBuilder.Entity<TpayPfpaymentpart>(entity =>
            {
                entity.HasKey(e => e.PfpaymentPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_pfpaymentpart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PfpaymentPartId).HasColumnName("PFPaymentPart_ID");

                entity.Property(e => e.PfpaymentPartCode).HasColumnName("PFPaymentPart_Code");

                entity.Property(e => e.PfpaymentPartExtCode)
                    .HasMaxLength(50)
                    .HasColumnName("PFPaymentPart_ExtCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PfpaymentPartFee).HasColumnName("PFPaymentPart_Fee");

                entity.Property(e => e.PfpaymentPartFeeType).HasColumnName("PFPaymentPart_FeeType");

                entity.Property(e => e.PfpaymentPartFloatParamA).HasColumnName("PFPaymentPart_FloatParamA");

                entity.Property(e => e.PfpaymentPartFloatParamB).HasColumnName("PFPaymentPart_FloatParamB");

                entity.Property(e => e.PfpaymentPartIntParamA).HasColumnName("PFPaymentPart_IntParamA");

                entity.Property(e => e.PfpaymentPartIntParamB).HasColumnName("PFPaymentPart_IntParamB");

                entity.Property(e => e.PfpaymentPartMaxFee).HasColumnName("PFPaymentPart_MaxFee");

                entity.Property(e => e.PfpaymentPartMinFee).HasColumnName("PFPaymentPart_MinFee");

                entity.Property(e => e.PfpaymentPartName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PFPaymentPart_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PfpaymentPartPfpaymentCode).HasColumnName("PFPaymentPart_PFPaymentCode");

                entity.Property(e => e.PfpaymentPartState).HasColumnName("PFPaymentPart_State");

                entity.Property(e => e.PfpaymentPartSyncState).HasColumnName("PFPaymentPart_SyncState");

                entity.Property(e => e.PfpaymentPartValue).HasColumnName("PFPaymentPart_Value");

                entity.Property(e => e.PfpaymentPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PFPaymentPart_VarParamA");

                entity.Property(e => e.PfpaymentPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PFPaymentPart_VarParamB");
            });

            modelBuilder.Entity<TpayPgmember>(entity =>
            {
                entity.HasKey(e => e.PgmemberId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_pgmember");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PgmemberId).HasColumnName("PGMember_ID");

                entity.Property(e => e.PgmemberDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGMember_Date");

                entity.Property(e => e.PgmemberExtMemberId)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("PGMember_ExtMemberID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgmemberFloatParamA).HasColumnName("PGMember_FloatParamA");

                entity.Property(e => e.PgmemberFloatParamB).HasColumnName("PGMember_FloatParamB");

                entity.Property(e => e.PgmemberIntParamA).HasColumnName("PGMember_IntParamA");

                entity.Property(e => e.PgmemberIntParamB).HasColumnName("PGMember_IntParamB");

                entity.Property(e => e.PgmemberMemberEmail)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("PGMember_MemberEmail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgmemberMemberName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("PGMember_MemberName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgmemberMemberPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PGMember_MemberPhone")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgmemberNo).HasColumnName("PGMember_No");

                entity.Property(e => e.PgmemberPaymentToken)
                    .HasMaxLength(50)
                    .HasColumnName("PGMember_PaymentToken")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgmemberState).HasColumnName("PGMember_State");

                entity.Property(e => e.PgmemberToken).HasColumnName("PGMember_Token");

                entity.Property(e => e.PgmemberVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PGMember_VarParamA");

                entity.Property(e => e.PgmemberVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PGMember_VarParamB");
            });

            modelBuilder.Entity<TpayPgorder>(entity =>
            {
                entity.HasKey(e => e.PgorderId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_pgorder");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PgorderId).HasColumnName("PGOrder_ID");

                entity.Property(e => e.PgorderAlertCount).HasColumnName("PGOrder_AlertCount");

                entity.Property(e => e.PgorderAllocateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_AllocateDate");

                entity.Property(e => e.PgorderAllocateState).HasColumnName("PGOrder_AllocateState");

                entity.Property(e => e.PgorderCancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_CancelDate");

                entity.Property(e => e.PgorderCancelState).HasColumnName("PGOrder_CancelState");

                entity.Property(e => e.PgorderCard4No)
                    .HasMaxLength(4)
                    .HasColumnName("PGOrder_Card4No")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderClearDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_ClearDate");

                entity.Property(e => e.PgorderClearState).HasColumnName("PGOrder_ClearState");

                entity.Property(e => e.PgorderContractStoreCode).HasColumnName("PGOrder_ContractStoreCode");

                entity.Property(e => e.PgorderCurrency)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("PGOrder_Currency")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_Expiry");

                entity.Property(e => e.PgorderExtMemberId)
                    .HasMaxLength(64)
                    .HasColumnName("PGOrder_ExtMemberID")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderExtOrderNo)
                    .HasMaxLength(50)
                    .HasColumnName("PGOrder_ExtOrderNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderExtraFeeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_ExtraFeeDate");

                entity.Property(e => e.PgorderExtraFeeState).HasColumnName("PGOrder_ExtraFeeState");

                entity.Property(e => e.PgorderFloatParamA).HasColumnName("PGOrder_FloatParamA");

                entity.Property(e => e.PgorderFloatParamB).HasColumnName("PGOrder_FloatParamB");

                entity.Property(e => e.PgorderInfo)
                    .HasMaxLength(200)
                    .HasColumnName("PGOrder_Info")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_InsertDate");

                entity.Property(e => e.PgorderIntParamA).HasColumnName("PGOrder_IntParamA");

                entity.Property(e => e.PgorderIntParamB).HasColumnName("PGOrder_IntParamB");

                entity.Property(e => e.PgorderMemberEmail)
                    .HasMaxLength(64)
                    .HasColumnName("PGOrder_MemberEmail")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderMemberName)
                    .HasMaxLength(30)
                    .HasColumnName("PGOrder_MemberName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderMemberPhone)
                    .HasMaxLength(20)
                    .HasColumnName("PGOrder_MemberPhone")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderMemo)
                    .HasColumnType("text")
                    .HasColumnName("PGOrder_Memo");

                entity.Property(e => e.PgorderNo).HasColumnName("PGOrder_No");

                entity.Property(e => e.PgorderPayAmount).HasColumnName("PGOrder_PayAmount");

                entity.Property(e => e.PgorderPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_PayDate");

                entity.Property(e => e.PgorderPayState).HasColumnName("PGOrder_PayState");

                entity.Property(e => e.PgorderPayUrl)
                    .HasMaxLength(500)
                    .HasColumnName("PGOrder_PayURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderPaymentFlowCode).HasColumnName("PGOrder_PaymentFlowCode");

                entity.Property(e => e.PgorderPaymentNo)
                    .HasMaxLength(50)
                    .HasColumnName("PGOrder_PaymentNo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderPaymentResult)
                    .HasColumnType("text")
                    .HasColumnName("PGOrder_PaymentResult");

                entity.Property(e => e.PgorderPfpaymentCode).HasColumnName("PGOrder_PFPaymentCode");

                entity.Property(e => e.PgorderPfpaymentPartCode).HasColumnName("PGOrder_PFPaymentPartCode");

                entity.Property(e => e.PgorderPfpaymentPartValue)
                    .HasMaxLength(50)
                    .HasColumnName("PGOrder_PFPaymentPartValue")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderPgmemberNo).HasColumnName("PGOrder_PGMemberNo");

                entity.Property(e => e.PgorderPgmemberToken).HasColumnName("PGOrder_PGMemberToken");

                entity.Property(e => e.PgorderRefundAmount).HasColumnName("PGOrder_RefundAmount");

                entity.Property(e => e.PgorderRefundCount).HasColumnName("PGOrder_RefundCount");

                entity.Property(e => e.PgorderRefundDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_RefundDate");

                entity.Property(e => e.PgorderRefundState).HasColumnName("PGOrder_RefundState");

                entity.Property(e => e.PgorderRequestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_RequestDate");

                entity.Property(e => e.PgorderRequestState).HasColumnName("PGOrder_RequestState");

                entity.Property(e => e.PgorderResultUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("PGOrder_ResultURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderState).HasColumnName("PGOrder_State");

                entity.Property(e => e.PgorderSupplierPayUrl)
                    .HasMaxLength(500)
                    .HasColumnName("PGOrder_SupplierPayURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderType).HasColumnName("PGOrder_Type");

                entity.Property(e => e.PgorderUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrder_UpdateDate");

                entity.Property(e => e.PgorderVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PGOrder_VarParamA");

                entity.Property(e => e.PgorderVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PGOrder_VarParamB");
            });

            modelBuilder.Entity<TpayPgorderlog>(entity =>
            {
                entity.HasKey(e => e.PgorderLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_pgorderlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PgorderLogId).HasColumnName("PGOrderLog_ID");

                entity.Property(e => e.PgorderLogAmount).HasColumnName("PGOrderLog_Amount");

                entity.Property(e => e.PgorderLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PGOrderLog_Date");

                entity.Property(e => e.PgorderLogDealerName)
                    .HasMaxLength(30)
                    .HasColumnName("PGOrderLog_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PgorderLogFloatParamA).HasColumnName("PGOrderLog_FloatParamA");

                entity.Property(e => e.PgorderLogFloatParamB).HasColumnName("PGOrderLog_FloatParamB");

                entity.Property(e => e.PgorderLogIntParamA).HasColumnName("PGOrderLog_IntParamA");

                entity.Property(e => e.PgorderLogIntParamB).HasColumnName("PGOrderLog_IntParamB");

                entity.Property(e => e.PgorderLogPayActionState).HasColumnName("PGOrderLog_PayActionState");

                entity.Property(e => e.PgorderLogPgorderNo).HasColumnName("PGOrderLog_PGOrderNo");

                entity.Property(e => e.PgorderLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("PGOrderLog_VarParamA");

                entity.Property(e => e.PgorderLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("PGOrderLog_VarParamB");
            });

            modelBuilder.Entity<TpaySetbasevalue>(entity =>
            {
                entity.HasKey(e => e.SetBaseValueId)
                    .HasName("PRIMARY");

                entity.ToTable("tpay_setbasevalue");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SetBaseValueId).HasColumnName("SetBaseValue_ID");

                entity.Property(e => e.SetBaseValueCompanyCode).HasColumnName("SetBaseValue_CompanyCode");

                entity.Property(e => e.SetBaseValueFloatParamA).HasColumnName("SetBaseValue_FloatParamA");

                entity.Property(e => e.SetBaseValueFloatParamB).HasColumnName("SetBaseValue_FloatParamB");

                entity.Property(e => e.SetBaseValueHashIv)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("SetBaseValue_HashIV")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SetBaseValueHashKey)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("SetBaseValue_HashKey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SetBaseValueIntParamA).HasColumnName("SetBaseValue_IntParamA");

                entity.Property(e => e.SetBaseValueIntParamB).HasColumnName("SetBaseValue_IntParamB");

                entity.Property(e => e.SetBaseValueLimitIp)
                    .HasMaxLength(500)
                    .HasColumnName("SetBaseValue_LimitIP")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SetBaseValueState).HasColumnName("SetBaseValue_State");

                entity.Property(e => e.SetBaseValueSyncState).HasColumnName("SetBaseValue_SyncState");

                entity.Property(e => e.SetBaseValueVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("SetBaseValue_VarParamA");

                entity.Property(e => e.SetBaseValueVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("SetBaseValue_VarParamB");
            });

            modelBuilder.Entity<TpntGame>(entity =>
            {
                entity.HasKey(e => e.GameId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_game");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.GameType, e.GameCode, e.GameOnDate, e.GameOffDate, e.GameOnlineDate, e.GameOfflineDate }, "Index");

                entity.Property(e => e.GameId).HasColumnName("Game_ID");

                entity.Property(e => e.GameAdimage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Game_ADImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameCode).HasColumnName("Game_Code");

                entity.Property(e => e.GameConditionType).HasColumnName("Game_ConditionType");

                entity.Property(e => e.GameCountryCode).HasColumnName("Game_CountryCode");

                entity.Property(e => e.GameDedPoint).HasColumnName("Game_DedPoint");

                entity.Property(e => e.GameExtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Game_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameFloatParamA).HasColumnName("Game_FloatParamA");

                entity.Property(e => e.GameFloatParamB).HasColumnName("Game_FloatParamB");

                entity.Property(e => e.GameImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Game_Image")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameIntParamA).HasColumnName("Game_IntParamA");

                entity.Property(e => e.GameIntParamB).HasColumnName("Game_IntParamB");

                entity.Property(e => e.GameIsDayLimit).HasColumnName("Game_IsDayLimit");

                entity.Property(e => e.GameIsOnline).HasColumnName("Game_IsOnline");

                entity.Property(e => e.GameMsgBody)
                    .HasColumnType("text")
                    .HasColumnName("Game_MsgBody");

                entity.Property(e => e.GameMsgLbtext)
                    .HasMaxLength(10)
                    .HasColumnName("Game_MsgLBText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameMsgLburl)
                    .HasMaxLength(200)
                    .HasColumnName("Game_MsgLBURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameMsgRbtext)
                    .HasMaxLength(10)
                    .HasColumnName("Game_MsgRBText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameMsgRburl)
                    .HasMaxLength(200)
                    .HasColumnName("Game_MsgRBURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Game_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Game_OffDate");

                entity.Property(e => e.GameOfflineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Game_OfflineDate");

                entity.Property(e => e.GameOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Game_OnDate");

                entity.Property(e => e.GameOnlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Game_OnlineDate");

                entity.Property(e => e.GamePlayCondition)
                    .HasColumnType("text")
                    .HasColumnName("Game_PlayCondition");

                entity.Property(e => e.GamePlayCount).HasColumnName("Game_PlayCount");

                entity.Property(e => e.GameRuleText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Game_RuleText");

                entity.Property(e => e.GameScratchImage)
                    .HasMaxLength(200)
                    .HasColumnName("Game_ScratchImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameScratchItemImage)
                    .HasMaxLength(200)
                    .HasColumnName("Game_ScratchItemImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameState).HasColumnName("Game_State");

                entity.Property(e => e.GameSyncState).HasColumnName("Game_SyncState");

                entity.Property(e => e.GameTag)
                    .HasMaxLength(50)
                    .HasColumnName("Game_Tag")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameTemplateState).HasColumnName("Game_TemplateState");

                entity.Property(e => e.GameType).HasColumnName("Game_Type");

                entity.Property(e => e.GameTypeSpace).HasColumnName("Game_TypeSpace");

                entity.Property(e => e.GameVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Game_VarParamA");

                entity.Property(e => e.GameVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Game_VarParamB");
            });

            modelBuilder.Entity<TpntGamecondpart>(entity =>
            {
                entity.HasKey(e => e.GameCondPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_gamecondpart");

                entity.Property(e => e.GameCondPartId).HasColumnName("GameCondPart_ID");

                entity.Property(e => e.GameCondPartFloatParamA).HasColumnName("GameCondPart_FloatParamA");

                entity.Property(e => e.GameCondPartFloatParamB).HasColumnName("GameCondPart_FloatParamB");

                entity.Property(e => e.GameCondPartGameCode).HasColumnName("GameCondPart_GameCode");

                entity.Property(e => e.GameCondPartIntParamA).HasColumnName("GameCondPart_IntParamA");

                entity.Property(e => e.GameCondPartIntParamB).HasColumnName("GameCondPart_IntParamB");

                entity.Property(e => e.GameCondPartItemCode).HasColumnName("GameCondPart_ItemCode");

                entity.Property(e => e.GameCondPartItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("GameCondPart_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GameCondPartState).HasColumnName("GameCondPart_State");

                entity.Property(e => e.GameCondPartSyncState).HasColumnName("GameCondPart_SyncState");

                entity.Property(e => e.GameCondPartType).HasColumnName("GameCondPart_Type");

                entity.Property(e => e.GameCondPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("GameCondPart_VarParamA");

                entity.Property(e => e.GameCondPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("GameCondPart_VarParamB");
            });

            modelBuilder.Entity<TpntGamelog>(entity =>
            {
                entity.HasKey(e => e.GameLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_gamelog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.GameLogUserInfoCode, e.GameLogGameCode, e.GameLogGamePartId }, "Index");

                entity.Property(e => e.GameLogId).HasColumnName("GameLog_ID");

                entity.Property(e => e.GameLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GameLog_Date");

                entity.Property(e => e.GameLogFloatParamA).HasColumnName("GameLog_FloatParamA");

                entity.Property(e => e.GameLogFloatParamB).HasColumnName("GameLog_FloatParamB");

                entity.Property(e => e.GameLogGameCode).HasColumnName("GameLog_GameCode");

                entity.Property(e => e.GameLogGamePartId).HasColumnName("GameLog_GamePartID");

                entity.Property(e => e.GameLogGamePartType).HasColumnName("GameLog_GamePartType");

                entity.Property(e => e.GameLogIntParamA).HasColumnName("GameLog_IntParamA");

                entity.Property(e => e.GameLogIntParamB).HasColumnName("GameLog_IntParamB");

                entity.Property(e => e.GameLogSendState).HasColumnName("GameLog_SendState");

                entity.Property(e => e.GameLogUserInfoCode).HasColumnName("GameLog_UserInfoCode");

                entity.Property(e => e.GameLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("GameLog_VarParamA");

                entity.Property(e => e.GameLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("GameLog_VarParamB");
            });

            modelBuilder.Entity<TpntGamepart>(entity =>
            {
                entity.HasKey(e => e.GamePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_gamepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.GamePartGameCode, e.GamePartType, e.GamePartItemId, e.GamePartItemCode, e.GamePartState }, "Index");

                entity.Property(e => e.GamePartId).HasColumnName("GamePart_ID");

                entity.Property(e => e.GamePartAttributeValueCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("GamePart_AttributeValueCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GamePartAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("GamePart_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GamePartFloatParamA).HasColumnName("GamePart_FloatParamA");

                entity.Property(e => e.GamePartFloatParamB).HasColumnName("GamePart_FloatParamB");

                entity.Property(e => e.GamePartGameCode).HasColumnName("GamePart_GameCode");

                entity.Property(e => e.GamePartIntParamA).HasColumnName("GamePart_IntParamA");

                entity.Property(e => e.GamePartIntParamB).HasColumnName("GamePart_IntParamB");

                entity.Property(e => e.GamePartItemCode).HasColumnName("GamePart_ItemCode");

                entity.Property(e => e.GamePartItemId).HasColumnName("GamePart_ItemID");

                entity.Property(e => e.GamePartItemImage)
                    .HasMaxLength(200)
                    .HasColumnName("GamePart_ItemImage")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GamePartItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("GamePart_ItemName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.GamePartProportion).HasColumnName("GamePart_Proportion");

                entity.Property(e => e.GamePartQty).HasColumnName("GamePart_QTY");

                entity.Property(e => e.GamePartReleasedQty).HasColumnName("GamePart_ReleasedQTY");

                entity.Property(e => e.GamePartState).HasColumnName("GamePart_State");

                entity.Property(e => e.GamePartSyncState).HasColumnName("GamePart_SyncState");

                entity.Property(e => e.GamePartType).HasColumnName("GamePart_Type");

                entity.Property(e => e.GamePartValues).HasColumnName("GamePart_Values");

                entity.Property(e => e.GamePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("GamePart_VarParamA");

                entity.Property(e => e.GamePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("GamePart_VarParamB");
            });

            modelBuilder.Entity<TpntMission>(entity =>
            {
                entity.HasKey(e => e.MissionId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_mission");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.MissionCode, e.MissionType, e.MissionReleasedCount, e.MissionIssuanceLimit, e.MissionCompleteCount, e.MissionOnDate, e.MissionOffDate, e.MissionOnlineDate, e.MissionOfflineDate, e.MissionState }, "Index");

                entity.Property(e => e.MissionId).HasColumnName("Mission_ID");

                entity.Property(e => e.MissionAutoReleased).HasColumnName("Mission_AutoReleased");

                entity.Property(e => e.MissionCode).HasColumnName("Mission_Code");

                entity.Property(e => e.MissionCompleteCount).HasColumnName("Mission_CompleteCount");

                entity.Property(e => e.MissionCompleteRule)
                    .HasColumnType("text")
                    .HasColumnName("Mission_CompleteRule");

                entity.Property(e => e.MissionCompleteType).HasColumnName("Mission_CompleteType");

                entity.Property(e => e.MissionCondition)
                    .HasColumnType("text")
                    .HasColumnName("Mission_Condition");

                entity.Property(e => e.MissionCountryCode).HasColumnName("Mission_CountryCode");

                entity.Property(e => e.MissionCurrentUrl)
                    .HasMaxLength(200)
                    .HasColumnName("Mission_CurrentURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionCurrentUrltarget)
                    .HasMaxLength(10)
                    .HasColumnName("Mission_CurrentURLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionExtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Mission_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionFloatParamA).HasColumnName("Mission_FloatParamA");

                entity.Property(e => e.MissionFloatParamB).HasColumnName("Mission_FloatParamB");

                entity.Property(e => e.MissionFreq).HasColumnName("Mission_Freq");

                entity.Property(e => e.MissionFreqValue).HasColumnName("Mission_FreqValue");

                entity.Property(e => e.MissionImage)
                    .HasMaxLength(200)
                    .HasColumnName("Mission_Image")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionInfo)
                    .HasColumnType("text")
                    .HasColumnName("Mission_Info");

                entity.Property(e => e.MissionIntParamA).HasColumnName("Mission_IntParamA");

                entity.Property(e => e.MissionIntParamB).HasColumnName("Mission_IntParamB");

                entity.Property(e => e.MissionIsDoneUp).HasColumnName("Mission_IsDoneUp");

                entity.Property(e => e.MissionIsOnline).HasColumnName("Mission_IsOnline");

                entity.Property(e => e.MissionIsSendMsg).HasColumnName("Mission_IsSendMsg");

                entity.Property(e => e.MissionIssuanceLimit).HasColumnName("Mission_IssuanceLimit");

                entity.Property(e => e.MissionLimitTotalValue).HasColumnName("Mission_LimitTotalValue");

                entity.Property(e => e.MissionLimitValue).HasColumnName("Mission_LimitValue");

                entity.Property(e => e.MissionName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Mission_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Mission_OffDate");

                entity.Property(e => e.MissionOfflineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Mission_OfflineDate");

                entity.Property(e => e.MissionOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Mission_OnDate");

                entity.Property(e => e.MissionOnlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Mission_OnlineDate");

                entity.Property(e => e.MissionReDirUrl)
                    .HasMaxLength(200)
                    .HasColumnName("Mission_ReDirURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionReceiveLimit).HasColumnName("Mission_ReceiveLimit");

                entity.Property(e => e.MissionReleasedCount).HasColumnName("Mission_ReleasedCount");

                entity.Property(e => e.MissionReleasedValue).HasColumnName("Mission_ReleasedValue");

                entity.Property(e => e.MissionRuleDec)
                    .HasColumnType("text")
                    .HasColumnName("Mission_RuleDec");

                entity.Property(e => e.MissionState).HasColumnName("Mission_State");

                entity.Property(e => e.MissionSyncState).HasColumnName("Mission_SyncState");

                entity.Property(e => e.MissionTemplateState).HasColumnName("Mission_TemplateState");

                entity.Property(e => e.MissionType).HasColumnName("Mission_Type");

                entity.Property(e => e.MissionUpMissionCode).HasColumnName("Mission_UpMissionCode");

                entity.Property(e => e.MissionUrl)
                    .HasMaxLength(200)
                    .HasColumnName("Mission_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionUrltitle)
                    .HasMaxLength(50)
                    .HasColumnName("Mission_URLTitle")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionValue).HasColumnName("Mission_Value");

                entity.Property(e => e.MissionVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Mission_VarParamA");

                entity.Property(e => e.MissionVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Mission_VarParamB");

                entity.Property(e => e.MissionVoucher)
                    .HasColumnType("text")
                    .HasColumnName("Mission_Voucher");
            });

            modelBuilder.Entity<TpntMissionjoblist>(entity =>
            {
                entity.HasKey(e => e.MissionJobListId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_missionjoblist");

                entity.Property(e => e.MissionJobListId).HasColumnName("MissionJobList_ID");

                entity.Property(e => e.MissionJobListActionCode).HasColumnName("MissionJobList_ActionCode");

                entity.Property(e => e.MissionJobListDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MissionJobList_Date");

                entity.Property(e => e.MissionJobListFloatParamA).HasColumnName("MissionJobList_FloatParamA");

                entity.Property(e => e.MissionJobListFloatParamB).HasColumnName("MissionJobList_FloatParamB");

                entity.Property(e => e.MissionJobListHandleDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MissionJobList_HandleDate");

                entity.Property(e => e.MissionJobListHandleState).HasColumnName("MissionJobList_HandleState");

                entity.Property(e => e.MissionJobListIntParamA).HasColumnName("MissionJobList_IntParamA");

                entity.Property(e => e.MissionJobListIntParamB).HasColumnName("MissionJobList_IntParamB");

                entity.Property(e => e.MissionJobListUserInfoCode).HasColumnName("MissionJobList_UserInfoCode");

                entity.Property(e => e.MissionJobListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MissionJobList_VarParamA");

                entity.Property(e => e.MissionJobListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MissionJobList_VarParamB");

                entity.Property(e => e.MissionJobListtOtherCode).HasColumnName("MissionJobListt_OtherCode");
            });

            modelBuilder.Entity<TpntMissionlog>(entity =>
            {
                entity.HasKey(e => e.MissionLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_missionlog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.MissionLogUserInfoCode, e.MissionLogMissionCode }, "Index");

                entity.Property(e => e.MissionLogId).HasColumnName("MissionLog_ID");

                entity.Property(e => e.MissionLogActionCode).HasColumnName("MissionLog_ActionCode");

                entity.Property(e => e.MissionLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MissionLog_Date");

                entity.Property(e => e.MissionLogFloatParamA).HasColumnName("MissionLog_FloatParamA");

                entity.Property(e => e.MissionLogFloatParamB).HasColumnName("MissionLog_FloatParamB");

                entity.Property(e => e.MissionLogIntParamA).HasColumnName("MissionLog_IntParamA");

                entity.Property(e => e.MissionLogIntParamB).HasColumnName("MissionLog_IntParamB");

                entity.Property(e => e.MissionLogMissionCode).HasColumnName("MissionLog_MissionCode");

                entity.Property(e => e.MissionLogUserInfoCode).HasColumnName("MissionLog_UserInfoCode");

                entity.Property(e => e.MissionLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MissionLog_VarParamA");

                entity.Property(e => e.MissionLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MissionLog_VarParamB");
            });

            modelBuilder.Entity<TpntMissionopertlog>(entity =>
            {
                entity.HasKey(e => e.MissionOpertLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_missionopertlog");

                entity.Property(e => e.MissionOpertLogId).HasColumnName("MissionOpertLog_ID");

                entity.Property(e => e.MissionOpertLogActionState).HasColumnName("MissionOpertLog_ActionState");

                entity.Property(e => e.MissionOpertLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MissionOpertLog_Date");

                entity.Property(e => e.MissionOpertLogDealerName)
                    .HasMaxLength(30)
                    .HasColumnName("MissionOpertLog_DealerName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MissionOpertLogFloatParamA).HasColumnName("MissionOpertLog_FloatParamA");

                entity.Property(e => e.MissionOpertLogFloatParamB).HasColumnName("MissionOpertLog_FloatParamB");

                entity.Property(e => e.MissionOpertLogIntParamA).HasColumnName("MissionOpertLog_IntParamA");

                entity.Property(e => e.MissionOpertLogIntParamB).HasColumnName("MissionOpertLog_IntParamB");

                entity.Property(e => e.MissionOpertLogJsonMission)
                    .HasColumnType("text")
                    .HasColumnName("MissionOpertLog_JsonMission");

                entity.Property(e => e.MissionOpertLogJsonMissionPart)
                    .HasColumnType("text")
                    .HasColumnName("MissionOpertLog_JsonMissionPart");

                entity.Property(e => e.MissionOpertLogMemo)
                    .HasColumnType("text")
                    .HasColumnName("MissionOpertLog_Memo");

                entity.Property(e => e.MissionOpertLogMissionCode).HasColumnName("MissionOpertLog_MissionCode");

                entity.Property(e => e.MissionOpertLogSyncState).HasColumnName("MissionOpertLog_SyncState");

                entity.Property(e => e.MissionOpertLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MissionOpertLog_VarParamA");

                entity.Property(e => e.MissionOpertLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MissionOpertLog_VarParamB");
            });

            modelBuilder.Entity<TpntMissionpart>(entity =>
            {
                entity.HasKey(e => e.MissionPartId)
                    .HasName("PRIMARY");

                entity.ToTable("tpnt_missionpart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.MissionPartActionCode, e.MissionPartMissionCode }, "Index");

                entity.Property(e => e.MissionPartId).HasColumnName("MissionPart_ID");

                entity.Property(e => e.MissionPartActionCode).HasColumnName("MissionPart_ActionCode");

                entity.Property(e => e.MissionPartFloatParamA).HasColumnName("MissionPart_FloatParamA");

                entity.Property(e => e.MissionPartFloatParamB).HasColumnName("MissionPart_FloatParamB");

                entity.Property(e => e.MissionPartIntParamA).HasColumnName("MissionPart_IntParamA");

                entity.Property(e => e.MissionPartIntParamB).HasColumnName("MissionPart_IntParamB");

                entity.Property(e => e.MissionPartMissionCode).HasColumnName("MissionPart_MissionCode");

                entity.Property(e => e.MissionPartState).HasColumnName("MissionPart_State");

                entity.Property(e => e.MissionPartSyncState).HasColumnName("MissionPart_SyncState");

                entity.Property(e => e.MissionPartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MissionPart_VarParamA");

                entity.Property(e => e.MissionPartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MissionPart_VarParamB");
            });

            modelBuilder.Entity<TvouSpree>(entity =>
            {
                entity.HasKey(e => e.SpreeId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_spree");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.SpreeCode, e.SpreeUsedOffDate, e.SpreeUsedOnDate, e.SpreeOnlineDate, e.SpreeOfflineDate, e.SpreeState, e.SpreeReleasedCount, e.SpreeIssuanceLimit, e.SpreeReceiveLimit }, "Index");

                entity.Property(e => e.SpreeId).HasColumnName("Spree_ID");

                entity.Property(e => e.SpreeCode).HasColumnName("Spree_Code");

                entity.Property(e => e.SpreeCompanyCode).HasColumnName("Spree_CompanyCode");

                entity.Property(e => e.SpreeContent)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Spree_Content")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeCountryCode).HasColumnName("Spree_CountryCode");

                entity.Property(e => e.SpreeEcstoreCode).HasColumnName("Spree_ECStoreCode");

                entity.Property(e => e.SpreeExtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Spree_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeFloatParamA).HasColumnName("Spree_FloatParamA");

                entity.Property(e => e.SpreeFloatParamB).HasColumnName("Spree_FloatParamB");

                entity.Property(e => e.SpreeImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Spree_Image")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeImg)
                    .HasMaxLength(200)
                    .HasColumnName("Spree_Img")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeIntParamA).HasColumnName("Spree_IntParamA");

                entity.Property(e => e.SpreeIntParamB).HasColumnName("Spree_IntParamB");

                entity.Property(e => e.SpreeIsOnline).HasColumnName("Spree_IsOnline");

                entity.Property(e => e.SpreeIssuanceLimit).HasColumnName("Spree_IssuanceLimit");

                entity.Property(e => e.SpreeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Spree_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeOfflineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Spree_OfflineDate");

                entity.Property(e => e.SpreeOnlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Spree_OnlineDate");

                entity.Property(e => e.SpreeReceiveLimit).HasColumnName("Spree_ReceiveLimit");

                entity.Property(e => e.SpreeReleasedCount).HasColumnName("Spree_ReleasedCount");

                entity.Property(e => e.SpreeState).HasColumnName("Spree_State");

                entity.Property(e => e.SpreeSyncState).HasColumnName("Spree_SyncState");

                entity.Property(e => e.SpreeUrl)
                    .HasMaxLength(500)
                    .HasColumnName("Spree_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeUrltarget)
                    .HasMaxLength(10)
                    .HasColumnName("Spree_URLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreeUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Spree_UsedOffDate");

                entity.Property(e => e.SpreeUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Spree_UsedOnDate");

                entity.Property(e => e.SpreeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Spree_VarParamA");

                entity.Property(e => e.SpreeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Spree_VarParamB");
            });

            modelBuilder.Entity<TvouSpreepart>(entity =>
            {
                entity.HasKey(e => e.SpreePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_spreepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.SpreePartType, e.SpreePartSpreeCode, e.SpreePartVoucherCode }, "Index");

                entity.Property(e => e.SpreePartId).HasColumnName("SpreePart_ID");

                entity.Property(e => e.SpreePartFloatParamA).HasColumnName("SpreePart_FloatParamA");

                entity.Property(e => e.SpreePartFloatParamB).HasColumnName("SpreePart_FloatParamB");

                entity.Property(e => e.SpreePartIntParamA).HasColumnName("SpreePart_IntParamA");

                entity.Property(e => e.SpreePartIntParamB).HasColumnName("SpreePart_IntParamB");

                entity.Property(e => e.SpreePartName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("SpreePart_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.SpreePartPoint).HasColumnName("SpreePart_Point");

                entity.Property(e => e.SpreePartSpreeCode).HasColumnName("SpreePart_SpreeCode");

                entity.Property(e => e.SpreePartState).HasColumnName("SpreePart_State");

                entity.Property(e => e.SpreePartSyncState).HasColumnName("SpreePart_SyncState");

                entity.Property(e => e.SpreePartType).HasColumnName("SpreePart_Type");

                entity.Property(e => e.SpreePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("SpreePart_VarParamA");

                entity.Property(e => e.SpreePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("SpreePart_VarParamB");

                entity.Property(e => e.SpreePartVoucherCode).HasColumnName("SpreePart_VoucherCode");
            });

            modelBuilder.Entity<TvouVoucher>(entity =>
            {
                entity.HasKey(e => e.VoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucher");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherCode, e.VoucherUsedType, e.VoucherType, e.VoucherCompanyCode, e.VoucherReleasedCount, e.VoucherIssuanceLimit, e.VoucherReceiveLimit, e.VoucherFeeType, e.VoucherUsedOnDate, e.VoucherUsedOffDate, e.VoucherOnlineDate, e.VoucherOfflineDate, e.VoucherState }, "Index");

                entity.Property(e => e.VoucherId).HasColumnName("Voucher_ID");

                entity.Property(e => e.VoucherActivityCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Voucher_ActivityCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherActivityType).HasColumnName("Voucher_ActivityType");

                entity.Property(e => e.VoucherCheckLimit).HasColumnName("Voucher_CheckLimit");

                entity.Property(e => e.VoucherCode).HasColumnName("Voucher_Code");

                entity.Property(e => e.VoucherCompanyCode).HasColumnName("Voucher_CompanyCode");

                entity.Property(e => e.VoucherContent)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Voucher_Content");

                entity.Property(e => e.VoucherCountryCode).HasColumnName("Voucher_CountryCode");

                entity.Property(e => e.VoucherDedPoint).HasColumnName("Voucher_DedPoint");

                entity.Property(e => e.VoucherEcstoreCode).HasColumnName("Voucher_ECStoreCode");

                entity.Property(e => e.VoucherExtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Voucher_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherFeeType).HasColumnName("Voucher_FeeType");

                entity.Property(e => e.VoucherFloatParamA).HasColumnName("Voucher_FloatParamA");

                entity.Property(e => e.VoucherFloatParamB).HasColumnName("Voucher_FloatParamB");

                entity.Property(e => e.VoucherImage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Voucher_Image")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherIntParamA).HasColumnName("Voucher_IntParamA");

                entity.Property(e => e.VoucherIntParamB).HasColumnName("Voucher_IntParamB");

                entity.Property(e => e.VoucherIsOnline).HasColumnName("Voucher_IsOnline");

                entity.Property(e => e.VoucherIsScan).HasColumnName("Voucher_IsScan");

                entity.Property(e => e.VoucherIssuanceLimit).HasColumnName("Voucher_IssuanceLimit");

                entity.Property(e => e.VoucherName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Voucher_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherNote)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("Voucher_Note");

                entity.Property(e => e.VoucherOfflineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Voucher_OfflineDate");

                entity.Property(e => e.VoucherOnlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Voucher_OnlineDate");

                entity.Property(e => e.VoucherReceiveLimit).HasColumnName("Voucher_ReceiveLimit");

                entity.Property(e => e.VoucherReleasedCount).HasColumnName("Voucher_ReleasedCount");

                entity.Property(e => e.VoucherShowType).HasColumnName("Voucher_ShowType");

                entity.Property(e => e.VoucherSpecialPoint).HasColumnName("Voucher_SpecialPoint");

                entity.Property(e => e.VoucherState).HasColumnName("Voucher_State");

                entity.Property(e => e.VoucherSyncState).HasColumnName("Voucher_SyncState");

                entity.Property(e => e.VoucherTemplateState).HasColumnName("Voucher_TemplateState");

                entity.Property(e => e.VoucherTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Voucher_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherType).HasColumnName("Voucher_Type");

                entity.Property(e => e.VoucherUrl)
                    .HasMaxLength(200)
                    .HasColumnName("Voucher_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherUrltarget)
                    .HasMaxLength(10)
                    .HasColumnName("Voucher_URLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherUsedLimit).HasColumnName("Voucher_UsedLimit");

                entity.Property(e => e.VoucherUsedLimitType).HasColumnName("Voucher_UsedLimitType");

                entity.Property(e => e.VoucherUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Voucher_UsedOffDate");

                entity.Property(e => e.VoucherUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Voucher_UsedOnDate");

                entity.Property(e => e.VoucherUsedType).HasColumnName("Voucher_UsedType");

                entity.Property(e => e.VoucherVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Voucher_VarParamA");

                entity.Property(e => e.VoucherVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Voucher_VarParamB");
            });

            modelBuilder.Entity<TvouVoucherad>(entity =>
            {
                entity.HasKey(e => e.VoucherAdId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucherad");

                entity.Property(e => e.VoucherAdId).HasColumnName("VoucherAD_ID");

                entity.Property(e => e.VoucherAdAdimgId).HasColumnName("VoucherAD_ADImgID");

                entity.Property(e => e.VoucherAdFloatParamA).HasColumnName("VoucherAD_FloatParamA");

                entity.Property(e => e.VoucherAdFloatParamB).HasColumnName("VoucherAD_FloatParamB");

                entity.Property(e => e.VoucherAdIntParamA).HasColumnName("VoucherAD_IntParamA");

                entity.Property(e => e.VoucherAdIntParamB).HasColumnName("VoucherAD_IntParamB");

                entity.Property(e => e.VoucherAdState).HasColumnName("VoucherAD_State");

                entity.Property(e => e.VoucherAdSyncState).HasColumnName("VoucherAD_SyncState");

                entity.Property(e => e.VoucherAdVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherAD_VarParamA");

                entity.Property(e => e.VoucherAdVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherAD_VarParamB");

                entity.Property(e => e.VoucherAdVoucherCode).HasColumnName("VoucherAD_VoucherCode");
            });

            modelBuilder.Entity<TvouVoucherattr>(entity =>
            {
                entity.HasKey(e => e.VoucherAttrId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucherattr");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherAttrVoucherCode, e.VoucherAttrAttributeType, e.VoucherAttrAttributeCode, e.VoucherAttrAttributeValueCode }, "Index");

                entity.Property(e => e.VoucherAttrId).HasColumnName("VoucherAttr_ID");

                entity.Property(e => e.VoucherAttrAttributeCode).HasColumnName("VoucherAttr_AttributeCode");

                entity.Property(e => e.VoucherAttrAttributeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VoucherAttr_AttributeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherAttrAttributeType).HasColumnName("VoucherAttr_AttributeType");

                entity.Property(e => e.VoucherAttrAttributeValueCode).HasColumnName("VoucherAttr_AttributeValueCode");

                entity.Property(e => e.VoucherAttrAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VoucherAttr_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherAttrFloatParamA).HasColumnName("VoucherAttr_FloatParamA");

                entity.Property(e => e.VoucherAttrFloatParamB).HasColumnName("VoucherAttr_FloatParamB");

                entity.Property(e => e.VoucherAttrIntParamA).HasColumnName("VoucherAttr_IntParamA");

                entity.Property(e => e.VoucherAttrIntParamB).HasColumnName("VoucherAttr_IntParamB");

                entity.Property(e => e.VoucherAttrIsShow).HasColumnName("VoucherAttr_IsShow");

                entity.Property(e => e.VoucherAttrIsShowtvouVoucherattrcol).HasColumnName("VoucherAttr_IsShowtvou_voucherattrcol");

                entity.Property(e => e.VoucherAttrSyncState).HasColumnName("VoucherAttr_SyncState");

                entity.Property(e => e.VoucherAttrVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherAttr_VarParamA");

                entity.Property(e => e.VoucherAttrVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherAttr_VarParamB");

                entity.Property(e => e.VoucherAttrVoucherCode).HasColumnName("VoucherAttr_VoucherCode");
            });

            modelBuilder.Entity<TvouVouchergive>(entity =>
            {
                entity.HasKey(e => e.VoucherGiveId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_vouchergive");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherGiveVoucherCode, e.VoucherGiveType, e.VoucherGiveMapCode }, "Index");

                entity.Property(e => e.VoucherGiveId).HasColumnName("VoucherGive_ID");

                entity.Property(e => e.VoucherGiveFloatParamA).HasColumnName("VoucherGive_FloatParamA");

                entity.Property(e => e.VoucherGiveFloatParamB).HasColumnName("VoucherGive_FloatParamB");

                entity.Property(e => e.VoucherGiveIntParamA).HasColumnName("VoucherGive_IntParamA");

                entity.Property(e => e.VoucherGiveIntParamB).HasColumnName("VoucherGive_IntParamB");

                entity.Property(e => e.VoucherGiveMapCode).HasColumnName("VoucherGive_MapCode");

                entity.Property(e => e.VoucherGiveState).HasColumnName("VoucherGive_State");

                entity.Property(e => e.VoucherGiveSyncState).HasColumnName("VoucherGive_SyncState");

                entity.Property(e => e.VoucherGiveType).HasColumnName("VoucherGive_Type");

                entity.Property(e => e.VoucherGiveVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherGive_VarParamA");

                entity.Property(e => e.VoucherGiveVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherGive_VarParamB");

                entity.Property(e => e.VoucherGiveVoucherCode).HasColumnName("VoucherGive_VoucherCode");
            });

            modelBuilder.Entity<TvouVoucherlimit>(entity =>
            {
                entity.HasKey(e => e.VoucherLimitId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucherlimit");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherLimitVoucherCode, e.VoucherLimitProductCode1, e.VoucherLimitProductCode2, e.VoucherLimitProductCode3, e.VoucherLimitProductCode4, e.VoucherLimitProductCode5 }, "Index");

                entity.Property(e => e.VoucherLimitId).HasColumnName("VoucherLimit_ID");

                entity.Property(e => e.VoucherLimitAfpcostPrice).HasColumnName("VoucherLimit_AFPCostPrice");

                entity.Property(e => e.VoucherLimitCostPrice).HasColumnName("VoucherLimit_CostPrice");

                entity.Property(e => e.VoucherLimitCount1).HasColumnName("VoucherLimit_Count1");

                entity.Property(e => e.VoucherLimitCount2).HasColumnName("VoucherLimit_Count2");

                entity.Property(e => e.VoucherLimitCount3).HasColumnName("VoucherLimit_Count3");

                entity.Property(e => e.VoucherLimitCount4).HasColumnName("VoucherLimit_Count4");

                entity.Property(e => e.VoucherLimitCount5).HasColumnName("VoucherLimit_Count5");

                entity.Property(e => e.VoucherLimitDiscount).HasColumnName("VoucherLimit_Discount");

                entity.Property(e => e.VoucherLimitFloatParamA).HasColumnName("VoucherLimit_FloatParamA");

                entity.Property(e => e.VoucherLimitFloatParamB).HasColumnName("VoucherLimit_FloatParamB");

                entity.Property(e => e.VoucherLimitIntParamA).HasColumnName("VoucherLimit_IntParamA");

                entity.Property(e => e.VoucherLimitIntParamB).HasColumnName("VoucherLimit_IntParamB");

                entity.Property(e => e.VoucherLimitIssuanceLimit).HasColumnName("VoucherLimit_IssuanceLimit");

                entity.Property(e => e.VoucherLimitMaxUnit).HasColumnName("VoucherLimit_MaxUnit");

                entity.Property(e => e.VoucherLimitMinUnit).HasColumnName("VoucherLimit_MinUnit");

                entity.Property(e => e.VoucherLimitProductCode1).HasColumnName("VoucherLimit_ProductCode1");

                entity.Property(e => e.VoucherLimitProductCode2).HasColumnName("VoucherLimit_ProductCode2");

                entity.Property(e => e.VoucherLimitProductCode3).HasColumnName("VoucherLimit_ProductCode3");

                entity.Property(e => e.VoucherLimitProductCode4).HasColumnName("VoucherLimit_ProductCode4");

                entity.Property(e => e.VoucherLimitProductCode5).HasColumnName("VoucherLimit_ProductCode5");

                entity.Property(e => e.VoucherLimitState).HasColumnName("VoucherLimit_State");

                entity.Property(e => e.VoucherLimitSyncState).HasColumnName("VoucherLimit_SyncState");

                entity.Property(e => e.VoucherLimitUsedCount).HasColumnName("VoucherLimit_UsedCount");

                entity.Property(e => e.VoucherLimitVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherLimit_VarParamA");

                entity.Property(e => e.VoucherLimitVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherLimit_VarParamB");

                entity.Property(e => e.VoucherLimitVoucherCode).HasColumnName("VoucherLimit_VoucherCode");
            });

            modelBuilder.Entity<TvouVouchermodel>(entity =>
            {
                entity.HasKey(e => e.VoucherModelId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_vouchermodel");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VoucherModelId).HasColumnName("VoucherModel_ID");

                entity.Property(e => e.VoucherModelChkBoxModel)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("VoucherModel_ChkBoxModel");

                entity.Property(e => e.VoucherModelCountryCode).HasColumnName("VoucherModel_CountryCode");

                entity.Property(e => e.VoucherModelDataModel)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("VoucherModel_DataModel");

                entity.Property(e => e.VoucherModelFloatParamA).HasColumnName("VoucherModel_FloatParamA");

                entity.Property(e => e.VoucherModelFloatParamB).HasColumnName("VoucherModel_FloatParamB");

                entity.Property(e => e.VoucherModelIntParamA).HasColumnName("VoucherModel_IntParamA");

                entity.Property(e => e.VoucherModelIntParamB).HasColumnName("VoucherModel_IntParamB");

                entity.Property(e => e.VoucherModelName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("VoucherModel_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VoucherModelState).HasColumnName("VoucherModel_State");

                entity.Property(e => e.VoucherModelVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherModel_VarParamA");

                entity.Property(e => e.VoucherModelVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherModel_VarParamB");
            });

            modelBuilder.Entity<TvouVoucherprodlist>(entity =>
            {
                entity.HasKey(e => e.VoucherProdListId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucherprodlist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherProdListProdListCode, e.VoucherProdListVoucherCode, e.VoucherProdListMode }, "Index");

                entity.Property(e => e.VoucherProdListId).HasColumnName("VoucherProdList_ID");

                entity.Property(e => e.VoucherProdListFloatParamA).HasColumnName("VoucherProdList_FloatParamA");

                entity.Property(e => e.VoucherProdListFloatParamB).HasColumnName("VoucherProdList_FloatParamB");

                entity.Property(e => e.VoucherProdListIntParamA).HasColumnName("VoucherProdList_IntParamA");

                entity.Property(e => e.VoucherProdListIntParamB).HasColumnName("VoucherProdList_IntParamB");

                entity.Property(e => e.VoucherProdListMode).HasColumnName("VoucherProdList_Mode");

                entity.Property(e => e.VoucherProdListProdListCode).HasColumnName("VoucherProdList_ProdListCode");

                entity.Property(e => e.VoucherProdListSyncState).HasColumnName("VoucherProdList_SyncState");

                entity.Property(e => e.VoucherProdListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherProdList_VarParamA");

                entity.Property(e => e.VoucherProdListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherProdList_VarParamB");

                entity.Property(e => e.VoucherProdListVoucherCode).HasColumnName("VoucherProdList_VoucherCode");
            });

            modelBuilder.Entity<TvouVoucherrange>(entity =>
            {
                entity.HasKey(e => e.VoucherRangeId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucherrange");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherRangeMapCode, e.VoucherRangeVoucherCode, e.VoucherRangeType }, "Index");

                entity.Property(e => e.VoucherRangeId).HasColumnName("VoucherRange_ID");

                entity.Property(e => e.VoucherRangeFloatParamA).HasColumnName("VoucherRange_FloatParamA");

                entity.Property(e => e.VoucherRangeFloatParamB).HasColumnName("VoucherRange_FloatParamB");

                entity.Property(e => e.VoucherRangeIntParamA).HasColumnName("VoucherRange_IntParamA");

                entity.Property(e => e.VoucherRangeIntParamB).HasColumnName("VoucherRange_IntParamB");

                entity.Property(e => e.VoucherRangeMapCode).HasColumnName("VoucherRange_MapCode");

                entity.Property(e => e.VoucherRangeState).HasColumnName("VoucherRange_State");

                entity.Property(e => e.VoucherRangeSyncState).HasColumnName("VoucherRange_SyncState");

                entity.Property(e => e.VoucherRangeType).HasColumnName("VoucherRange_Type");

                entity.Property(e => e.VoucherRangeVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherRange_VarParamA");

                entity.Property(e => e.VoucherRangeVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherRange_VarParamB");

                entity.Property(e => e.VoucherRangeVoucherCode).HasColumnName("VoucherRange_VoucherCode");
            });

            modelBuilder.Entity<TvouVoucherstore>(entity =>
            {
                entity.HasKey(e => e.VoucherStoreId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voucherstore");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherStoreEcstoreCode, e.VoucherStoreVoucherCode }, "Index");

                entity.Property(e => e.VoucherStoreId).HasColumnName("VoucherStore_ID");

                entity.Property(e => e.VoucherStoreEcstoreCode).HasColumnName("VoucherStore_ECStoreCode");

                entity.Property(e => e.VoucherStoreFloatParamA).HasColumnName("VoucherStore_FloatParamA");

                entity.Property(e => e.VoucherStoreFloatParamB).HasColumnName("VoucherStore_FloatParamB");

                entity.Property(e => e.VoucherStoreIntParamA).HasColumnName("VoucherStore_IntParamA");

                entity.Property(e => e.VoucherStoreIntParamB).HasColumnName("VoucherStore_IntParamB");

                entity.Property(e => e.VoucherStoreSyncState).HasColumnName("VoucherStore_SyncState");

                entity.Property(e => e.VoucherStoreVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherStore_VarParamA");

                entity.Property(e => e.VoucherStoreVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherStore_VarParamB");

                entity.Property(e => e.VoucherStoreVoucherCode).HasColumnName("VoucherStore_VoucherCode");
            });

            modelBuilder.Entity<TvouVouchervoulist>(entity =>
            {
                entity.HasKey(e => e.VoucherVouListId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_vouchervoulist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VoucherVouListVoucherCode, e.VoucherVouListVouListCode, e.VoucherVouListMode }, "Index");

                entity.Property(e => e.VoucherVouListId).HasColumnName("VoucherVouList_ID");

                entity.Property(e => e.VoucherVouListFloatParamA).HasColumnName("VoucherVouList_FloatParamA");

                entity.Property(e => e.VoucherVouListFloatParamB).HasColumnName("VoucherVouList_FloatParamB");

                entity.Property(e => e.VoucherVouListIntParamA).HasColumnName("VoucherVouList_IntParamA");

                entity.Property(e => e.VoucherVouListIntParamB).HasColumnName("VoucherVouList_IntParamB");

                entity.Property(e => e.VoucherVouListMode).HasColumnName("VoucherVouList_Mode");

                entity.Property(e => e.VoucherVouListSyncState).HasColumnName("VoucherVouList_SyncState");

                entity.Property(e => e.VoucherVouListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VoucherVouList_VarParamA");

                entity.Property(e => e.VoucherVouListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VoucherVouList_VarParamB");

                entity.Property(e => e.VoucherVouListVouListCode).HasColumnName("VoucherVouList_VouListCode");

                entity.Property(e => e.VoucherVouListVoucherCode).HasColumnName("VoucherVouList_VoucherCode");
            });

            modelBuilder.Entity<TvouVouflashsale>(entity =>
            {
                entity.HasKey(e => e.VouFlashSaleId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_vouflashsale");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VouFlashSaleCode, e.VouFlashSaleOnlineDate, e.VouFlashSaleOfflineDate }, "Index");

                entity.Property(e => e.VouFlashSaleId).HasColumnName("VouFlashSale_ID");

                entity.Property(e => e.VouFlashSaleCode).HasColumnName("VouFlashSale_Code");

                entity.Property(e => e.VouFlashSaleCountryCode).HasColumnName("VouFlashSale_CountryCode");

                entity.Property(e => e.VouFlashSaleExtName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("VouFlashSale_ExtName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouFlashSaleFloatParamA).HasColumnName("VouFlashSale_FloatParamA");

                entity.Property(e => e.VouFlashSaleFloatParamB).HasColumnName("VouFlashSale_FloatParamB");

                entity.Property(e => e.VouFlashSaleIntParamA).HasColumnName("VouFlashSale_IntParamA");

                entity.Property(e => e.VouFlashSaleIntParamB).HasColumnName("VouFlashSale_IntParamB");

                entity.Property(e => e.VouFlashSaleIsOnline).HasColumnName("VouFlashSale_IsOnline");

                entity.Property(e => e.VouFlashSaleName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("VouFlashSale_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouFlashSaleOfflineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VouFlashSale_OfflineDate");

                entity.Property(e => e.VouFlashSaleOnlineDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VouFlashSale_OnlineDate");

                entity.Property(e => e.VouFlashSaleState).HasColumnName("VouFlashSale_State");

                entity.Property(e => e.VouFlashSaleSyncState).HasColumnName("VouFlashSale_SyncState");

                entity.Property(e => e.VouFlashSaleVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VouFlashSale_VarParamA");

                entity.Property(e => e.VouFlashSaleVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VouFlashSale_VarParamB");
            });

            modelBuilder.Entity<TvouVouflashsalelog>(entity =>
            {
                entity.HasKey(e => e.VouFlashSaleLogId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_vouflashsalelog");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VouFlashSaleLogVouFlashSaleCode, e.VouFlashSaleLogTvouVouFlashSalePartId, e.VouFlashSaleLogVoucherCode, e.VouFlashSaleLogUserInfoCode }, "Index");

                entity.Property(e => e.VouFlashSaleLogId).HasColumnName("VouFlashSaleLog_ID");

                entity.Property(e => e.VouFlashSaleLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("VouFlashSaleLog_Date");

                entity.Property(e => e.VouFlashSaleLogFloatParamA).HasColumnName("VouFlashSaleLog_FloatParamA");

                entity.Property(e => e.VouFlashSaleLogFloatParamB).HasColumnName("VouFlashSaleLog_FloatParamB");

                entity.Property(e => e.VouFlashSaleLogIntParamA).HasColumnName("VouFlashSaleLog_IntParamA");

                entity.Property(e => e.VouFlashSaleLogIntParamB).HasColumnName("VouFlashSaleLog_IntParamB");

                entity.Property(e => e.VouFlashSaleLogTvouVouFlashSalePartId).HasColumnName("VouFlashSaleLog_TVou_VouFlashSalePartID");

                entity.Property(e => e.VouFlashSaleLogUserInfoCode).HasColumnName("VouFlashSaleLog_UserInfoCode");

                entity.Property(e => e.VouFlashSaleLogVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VouFlashSaleLog_VarParamA");

                entity.Property(e => e.VouFlashSaleLogVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VouFlashSaleLog_VarParamB");

                entity.Property(e => e.VouFlashSaleLogVouFlashSaleCode).HasColumnName("VouFlashSaleLog_VouFlashSaleCode");

                entity.Property(e => e.VouFlashSaleLogVoucherCode).HasColumnName("VouFlashSaleLog_VoucherCode");
            });

            modelBuilder.Entity<TvouVouflashsalepart>(entity =>
            {
                entity.HasKey(e => e.VouFlashSalePartId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_vouflashsalepart");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VouFlashSalePartVouFlashSaleCode, e.VouFlashSalePartVoucherCode }, "Index");

                entity.Property(e => e.VouFlashSalePartId).HasColumnName("VouFlashSalePart_ID");

                entity.Property(e => e.VouFlashSalePartFloatParamA).HasColumnName("VouFlashSalePart_FloatParamA");

                entity.Property(e => e.VouFlashSalePartFloatParamB).HasColumnName("VouFlashSalePart_FloatParamB");

                entity.Property(e => e.VouFlashSalePartFreqCount).HasColumnName("VouFlashSalePart_FreqCount");

                entity.Property(e => e.VouFlashSalePartFreqedCount).HasColumnName("VouFlashSalePart_FreqedCount");

                entity.Property(e => e.VouFlashSalePartIntParamA).HasColumnName("VouFlashSalePart_IntParamA");

                entity.Property(e => e.VouFlashSalePartIntParamB).HasColumnName("VouFlashSalePart_IntParamB");

                entity.Property(e => e.VouFlashSalePartSpecialPoint).HasColumnName("VouFlashSalePart_SpecialPoint");

                entity.Property(e => e.VouFlashSalePartState).HasColumnName("VouFlashSalePart_State");

                entity.Property(e => e.VouFlashSalePartVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VouFlashSalePart_VarParamA");

                entity.Property(e => e.VouFlashSalePartVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VouFlashSalePart_VarParamB");

                entity.Property(e => e.VouFlashSalePartVouFlashSaleCode).HasColumnName("VouFlashSalePart_VouFlashSaleCode");

                entity.Property(e => e.VouFlashSalePartVoucherCode).HasColumnName("VouFlashSalePart_VoucherCode");
            });

            modelBuilder.Entity<TvouVoulist>(entity =>
            {
                entity.HasKey(e => e.VouListId)
                    .HasName("PRIMARY");

                entity.ToTable("tvou_voulist");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.VouListUpVouListCode, e.VouListCode, e.VouListAttribute }, "Index");

                entity.Property(e => e.VouListId).HasColumnName("VouList_ID");

                entity.Property(e => e.VouListAttribute).HasColumnName("VouList_Attribute");

                entity.Property(e => e.VouListCode).HasColumnName("VouList_Code");

                entity.Property(e => e.VouListFloatParamA).HasColumnName("VouList_FloatParamA");

                entity.Property(e => e.VouListFloatParamB).HasColumnName("VouList_FloatParamB");

                entity.Property(e => e.VouListIntParamA).HasColumnName("VouList_IntParamA");

                entity.Property(e => e.VouListIntParamB).HasColumnName("VouList_IntParamB");

                entity.Property(e => e.VouListLayNo).HasColumnName("VouList_LayNo");

                entity.Property(e => e.VouListMemo)
                    .HasColumnType("text")
                    .HasColumnName("VouList_Memo");

                entity.Property(e => e.VouListName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("VouList_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouListPicUrl1)
                    .HasMaxLength(200)
                    .HasColumnName("VouList_PicUrl1")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouListPicUrl2)
                    .HasMaxLength(200)
                    .HasColumnName("VouList_PicUrl2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouListPicUrl3)
                    .HasMaxLength(200)
                    .HasColumnName("VouList_PicUrl3")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouListPicUrl4)
                    .HasMaxLength(200)
                    .HasColumnName("VouList_PicUrl4")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouListPicUrl5)
                    .HasMaxLength(200)
                    .HasColumnName("VouList_PicUrl5")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.VouListState).HasColumnName("VouList_State");

                entity.Property(e => e.VouListSyncState).HasColumnName("VouList_SyncState");

                entity.Property(e => e.VouListTemplateState).HasColumnName("VouList_TemplateState");

                entity.Property(e => e.VouListUpVouListCode).HasColumnName("VouList_UpVouListCode");

                entity.Property(e => e.VouListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("VouList_VarParamA");

                entity.Property(e => e.VouListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("VouList_VarParamB");
            });

            modelBuilder.Entity<TwebAdimg>(entity =>
            {
                entity.HasKey(e => e.AdimgId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_adimg");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.AdimgType, e.AdimgEcstoreCode, e.AdimgAdcode, e.AdimgReleaseDate, e.AdimgEndDate, e.AdimgSort }, "Index");

                entity.Property(e => e.AdimgId).HasColumnName("ADImg_ID");

                entity.Property(e => e.AdimgAdcode).HasColumnName("ADImg_ADCode");

                entity.Property(e => e.AdimgAppUrltarget)
                    .HasColumnName("ADImg_AppURLTarget")
                    .HasDefaultValueSql("'0'")
                    .HasComment("App開啟模式");

                entity.Property(e => e.AdimgEcstoreCode).HasColumnName("ADImg_ECStoreCode");

                entity.Property(e => e.AdimgEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADImg_EndDate");

                entity.Property(e => e.AdimgFloatParamA).HasColumnName("ADImg_FloatParamA");

                entity.Property(e => e.AdimgFloatParamB).HasColumnName("ADImg_FloatParamB");

                entity.Property(e => e.AdimgImg)
                    .HasMaxLength(200)
                    .HasColumnName("ADImg_Img")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AdimgIntParamA).HasColumnName("ADImg_IntParamA");

                entity.Property(e => e.AdimgIntParamB).HasColumnName("ADImg_IntParamB");

                entity.Property(e => e.AdimgName)
                    .HasMaxLength(50)
                    .HasColumnName("ADImg_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AdimgReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADImg_ReleaseDate");

                entity.Property(e => e.AdimgSort).HasColumnName("ADImg_Sort");

                entity.Property(e => e.AdimgState).HasColumnName("ADImg_State");

                entity.Property(e => e.AdimgSubTitle)
                    .HasMaxLength(200)
                    .HasColumnName("ADImg_SubTitle")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AdimgSyncState).HasColumnName("ADImg_SyncState");

                entity.Property(e => e.AdimgTitle)
                    .HasMaxLength(200)
                    .HasColumnName("ADImg_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AdimgType).HasColumnName("ADImg_Type");

                entity.Property(e => e.AdimgUrl)
                    .HasMaxLength(500)
                    .HasColumnName("ADImg_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AdimgUrltarget)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ADImg_URLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.AdimgVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("ADImg_VarParamA");

                entity.Property(e => e.AdimgVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("ADImg_VarParamB");

                entity.Property(e => e.AdimgVideoUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ADImg_VideoURL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<TwebFilesetting>(entity =>
            {
                entity.HasKey(e => e.FileSettingsId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_filesettings");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.FileSettingsMapCode, e.FileSettingsMode, e.FileSettingsSort }, "Index");

                entity.Property(e => e.FileSettingsId).HasColumnName("FileSettings_ID");

                entity.Property(e => e.FileSettingsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FileSettings_Date");

                entity.Property(e => e.FileSettingsFile)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("FileSettings_File")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FileSettingsFloatParamA).HasColumnName("FileSettings_FloatParamA");

                entity.Property(e => e.FileSettingsFloatParamB).HasColumnName("FileSettings_FloatParamB");

                entity.Property(e => e.FileSettingsIntParamA).HasColumnName("FileSettings_IntParamA");

                entity.Property(e => e.FileSettingsIntParamB).HasColumnName("FileSettings_IntParamB");

                entity.Property(e => e.FileSettingsMapCode).HasColumnName("FileSettings_MapCode");

                entity.Property(e => e.FileSettingsMode).HasColumnName("FileSettings_Mode");

                entity.Property(e => e.FileSettingsName)
                    .HasMaxLength(200)
                    .HasColumnName("FileSettings_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FileSettingsSort).HasColumnName("FileSettings_Sort");

                entity.Property(e => e.FileSettingsState).HasColumnName("FileSettings_State");

                entity.Property(e => e.FileSettingsSyncState).HasColumnName("FileSettings_SyncState");

                entity.Property(e => e.FileSettingsVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("FileSettings_VarParamA");

                entity.Property(e => e.FileSettingsVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("FileSettings_VarParamB");
            });

            modelBuilder.Entity<TwebFunction>(entity =>
            {
                entity.HasKey(e => e.FunctionId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_function");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.FunctionCode, e.FunctionSort, e.FunctionCategaryCode, e.FunctionMode, e.FunctionIsTop, e.FunctionIsOther, e.FunctionIsActive }, "Index");

                entity.Property(e => e.FunctionId).HasColumnName("Function_ID");

                entity.Property(e => e.FunctionCategaryCode).HasColumnName("Function_CategaryCode");

                entity.Property(e => e.FunctionCode).HasColumnName("Function_Code");

                entity.Property(e => e.FunctionCountryCode).HasColumnName("Function_CountryCode");

                entity.Property(e => e.FunctionFloatParamA).HasColumnName("Function_FloatParamA");

                entity.Property(e => e.FunctionFloatParamB).HasColumnName("Function_FloatParamB");

                entity.Property(e => e.FunctionIcon)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Function_Icon")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FunctionIntParamA).HasColumnName("Function_IntParamA");

                entity.Property(e => e.FunctionIntParamB).HasColumnName("Function_IntParamB");

                entity.Property(e => e.FunctionIsActive).HasColumnName("Function_IsActive");

                entity.Property(e => e.FunctionIsOther).HasColumnName("Function_IsOther");

                entity.Property(e => e.FunctionIsShow).HasColumnName("Function_IsShow");

                entity.Property(e => e.FunctionIsTop).HasColumnName("Function_IsTop");

                entity.Property(e => e.FunctionMode).HasColumnName("Function_Mode");

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Function_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FunctionSort).HasColumnName("Function_Sort");

                entity.Property(e => e.FunctionState).HasColumnName("Function_State");

                entity.Property(e => e.FunctionSyncState).HasColumnName("Function_SyncState");

                entity.Property(e => e.FunctionUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Function_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FunctionUrltarget)
                    .HasMaxLength(10)
                    .HasColumnName("Function_URLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.FunctionVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Function_VarParamA");

                entity.Property(e => e.FunctionVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Function_VarParamB");
            });

            modelBuilder.Entity<TwebImessage>(entity =>
            {
                entity.HasKey(e => e.ImessageId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_imessage");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.ImessageMsgCategoryCode, e.ImessageEcstoreCode, e.ImessageUserInfoCode, e.ImessageMode }, "Index");

                entity.Property(e => e.ImessageId).HasColumnName("IMessage_ID");

                entity.Property(e => e.ImessageBigImg)
                    .HasMaxLength(200)
                    .HasColumnName("IMessage_BigImg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ImessageBody)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("IMessage_Body");

                entity.Property(e => e.ImessageClickCount).HasColumnName("IMessage_ClickCount");

                entity.Property(e => e.ImessageCode).HasColumnName("IMessage_Code");

                entity.Property(e => e.ImessageDesc)
                    .HasMaxLength(200)
                    .HasColumnName("IMessage_Desc")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ImessageEcstoreCode).HasColumnName("IMessage_ECStoreCode");

                entity.Property(e => e.ImessageEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IMessage_EndDate");

                entity.Property(e => e.ImessageFloatParamA).HasColumnName("IMessage_FloatParamA");

                entity.Property(e => e.ImessageFloatParamB).HasColumnName("IMessage_FloatParamB");

                entity.Property(e => e.ImessageInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IMessage_InsertDate");

                entity.Property(e => e.ImessageIntParamA).HasColumnName("IMessage_IntParamA");

                entity.Property(e => e.ImessageIntParamB).HasColumnName("IMessage_IntParamB");

                entity.Property(e => e.ImessageIsShow).HasColumnName("IMessage_IsShow");

                entity.Property(e => e.ImessageIsShowCta).HasColumnName("IMessage_IsShowCTA");

                entity.Property(e => e.ImessageMode).HasColumnName("IMessage_Mode");

                entity.Property(e => e.ImessageMsgCategoryCode).HasColumnName("IMessage_MsgCategoryCode");

                entity.Property(e => e.ImessageOrderNo).HasColumnName("IMessage_OrderNo");

                entity.Property(e => e.ImessageReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IMessage_ReleaseDate");

                entity.Property(e => e.ImessageShareCount).HasColumnName("IMessage_ShareCount");

                entity.Property(e => e.ImessageSmallImg)
                    .HasMaxLength(200)
                    .HasColumnName("IMessage_SmallImg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ImessageSort).HasColumnName("IMessage_Sort");

                entity.Property(e => e.ImessageState).HasColumnName("IMessage_State");

                entity.Property(e => e.ImessageSyncState).HasColumnName("IMessage_SyncState");

                entity.Property(e => e.ImessageTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("IMessage_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ImessageUserInfoCode).HasColumnName("IMessage_UserInfoCode");

                entity.Property(e => e.ImessageVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("IMessage_VarParamA");

                entity.Property(e => e.ImessageVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("IMessage_VarParamB");
            });

            modelBuilder.Entity<TwebMsgcategory>(entity =>
            {
                entity.HasKey(e => e.MsgCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_msgcategory");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.MsgCategoryMode, e.MsgCategoryCode, e.MsgCategoryReleaseDate, e.MsgCategoryEndDate, e.MsgCategorySort }, "Index");

                entity.Property(e => e.MsgCategoryId).HasColumnName("MsgCategory_ID");

                entity.Property(e => e.MsgCategoryBigImg)
                    .HasMaxLength(200)
                    .HasColumnName("MsgCategory_BigImg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MsgCategoryCode).HasColumnName("MsgCategory_Code");

                entity.Property(e => e.MsgCategoryCountryCode).HasColumnName("MsgCategory_CountryCode");

                entity.Property(e => e.MsgCategoryEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MsgCategory_EndDate");

                entity.Property(e => e.MsgCategoryFloatParamA).HasColumnName("MsgCategory_FloatParamA");

                entity.Property(e => e.MsgCategoryFloatParamB).HasColumnName("MsgCategory_FloatParamB");

                entity.Property(e => e.MsgCategoryInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MsgCategory_InsertDate");

                entity.Property(e => e.MsgCategoryIntParamA).HasColumnName("MsgCategory_IntParamA");

                entity.Property(e => e.MsgCategoryIntParamB).HasColumnName("MsgCategory_IntParamB");

                entity.Property(e => e.MsgCategoryIsShow).HasColumnName("MsgCategory_IsShow");

                entity.Property(e => e.MsgCategoryMode).HasColumnName("MsgCategory_Mode");

                entity.Property(e => e.MsgCategoryName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("MsgCategory_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MsgCategoryReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MsgCategory_ReleaseDate");

                entity.Property(e => e.MsgCategorySmallImg)
                    .HasMaxLength(200)
                    .HasColumnName("MsgCategory_SmallImg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.MsgCategorySort).HasColumnName("MsgCategory_Sort");

                entity.Property(e => e.MsgCategoryState).HasColumnName("MsgCategory_State");

                entity.Property(e => e.MsgCategorySyncState).HasColumnName("MsgCategory_SyncState");

                entity.Property(e => e.MsgCategoryVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("MsgCategory_VarParamA");

                entity.Property(e => e.MsgCategoryVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("MsgCategory_VarParamB");
            });

            modelBuilder.Entity<TwebQuestioncontent>(entity =>
            {
                entity.HasKey(e => e.QuestionContentId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_questioncontent");

                entity.HasIndex(e => new { e.QuestionContentMode, e.QuestionContentCategoryCode, e.QuestionContentCode, e.QuestionContentReleaseDate, e.QuestionContentEndDate, e.QuestionContentSort, e.QuestionContentState }, "Index");

                entity.Property(e => e.QuestionContentId).HasColumnName("QuestionContent_ID");

                entity.Property(e => e.QuestionContentBody)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("QuestionContent_Body");

                entity.Property(e => e.QuestionContentCategoryCode).HasColumnName("QuestionContent_CategoryCode");

                entity.Property(e => e.QuestionContentCode).HasColumnName("QuestionContent_Code");

                entity.Property(e => e.QuestionContentEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QuestionContent_EndDate");

                entity.Property(e => e.QuestionContentFloatParamA).HasColumnName("QuestionContent_FloatParamA");

                entity.Property(e => e.QuestionContentFloatParamB).HasColumnName("QuestionContent_FloatParamB");

                entity.Property(e => e.QuestionContentInsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QuestionContent_InsertDate");

                entity.Property(e => e.QuestionContentInsertDealer)
                    .HasMaxLength(50)
                    .HasColumnName("QuestionContent_InsertDealer")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.QuestionContentIntParamA).HasColumnName("QuestionContent_IntParamA");

                entity.Property(e => e.QuestionContentIntParamB).HasColumnName("QuestionContent_IntParamB");

                entity.Property(e => e.QuestionContentIsShow).HasColumnName("QuestionContent_IsShow");

                entity.Property(e => e.QuestionContentMode).HasColumnName("QuestionContent_Mode");

                entity.Property(e => e.QuestionContentReleaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QuestionContent_ReleaseDate");

                entity.Property(e => e.QuestionContentSort).HasColumnName("QuestionContent_Sort");

                entity.Property(e => e.QuestionContentState).HasColumnName("QuestionContent_State");

                entity.Property(e => e.QuestionContentSyncState).HasColumnName("QuestionContent_SyncState");

                entity.Property(e => e.QuestionContentTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("QuestionContent_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.QuestionContentUpdatDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QuestionContent_UpdatDate");

                entity.Property(e => e.QuestionContentUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("QuestionContent_UpdateDate");

                entity.Property(e => e.QuestionContentUpdateDealer)
                    .HasMaxLength(50)
                    .HasColumnName("QuestionContent_UpdateDealer")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.QuestionContentVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("QuestionContent_VarParamA");

                entity.Property(e => e.QuestionContentVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("QuestionContent_VarParamB");
            });

            modelBuilder.Entity<TwebTravel>(entity =>
            {
                entity.HasKey(e => e.TravelId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_travel");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.TravelCode, e.TravelName }, "Index");

                entity.Property(e => e.TravelId).HasColumnName("Travel_ID");

                entity.Property(e => e.TravelCode).HasColumnName("Travel_Code");

                entity.Property(e => e.TravelFloatParamA).HasColumnName("Travel_FloatParamA");

                entity.Property(e => e.TravelFloatParamB).HasColumnName("Travel_FloatParamB");

                entity.Property(e => e.TravelImg)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Travel_Img")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelIntParamA).HasColumnName("Travel_IntParamA");

                entity.Property(e => e.TravelIntParamB).HasColumnName("Travel_IntParamB");

                entity.Property(e => e.TravelLocalTitle)
                    .HasMaxLength(50)
                    .HasColumnName("Travel_LocalTitle")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Travel_Name")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelState).HasColumnName("Travel_State");

                entity.Property(e => e.TravelSubTitle)
                    .HasMaxLength(200)
                    .HasColumnName("Travel_SubTitle")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelSyncState).HasColumnName("Travel_SyncState");

                entity.Property(e => e.TravelTemplateState).HasColumnName("Travel_TemplateState");

                entity.Property(e => e.TravelTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Travel_Title")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("Travel_URL")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelUrltarget)
                    .HasMaxLength(10)
                    .HasColumnName("Travel_URLTarget")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("Travel_VarParamA");

                entity.Property(e => e.TravelVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("Travel_VarParamB");
            });

            modelBuilder.Entity<TwebTravelattr>(entity =>
            {
                entity.HasKey(e => e.TravelAttrId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_travelattr");

                entity.UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => new { e.TravelAttrTravelCode, e.TravelAttrAttributeType, e.TravelAttrAttributeCode, e.TravelAttrAttributeValueCode }, "Index");

                entity.Property(e => e.TravelAttrId).HasColumnName("TravelAttr_ID");

                entity.Property(e => e.TravelAttrAttributeCode).HasColumnName("TravelAttr_AttributeCode");

                entity.Property(e => e.TravelAttrAttributeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TravelAttr_AttributeName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelAttrAttributeType).HasColumnName("TravelAttr_AttributeType");

                entity.Property(e => e.TravelAttrAttributeValueCode).HasColumnName("TravelAttr_AttributeValueCode");

                entity.Property(e => e.TravelAttrAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TravelAttr_AttributeValueName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TravelAttrFloatParamA).HasColumnName("TravelAttr_FloatParamA");

                entity.Property(e => e.TravelAttrFloatParamB).HasColumnName("TravelAttr_FloatParamB");

                entity.Property(e => e.TravelAttrIntParamA).HasColumnName("TravelAttr_IntParamA");

                entity.Property(e => e.TravelAttrIntParamB).HasColumnName("TravelAttr_IntParamB");

                entity.Property(e => e.TravelAttrIsShow).HasColumnName("TravelAttr_IsShow");

                entity.Property(e => e.TravelAttrSyncState).HasColumnName("TravelAttr_SyncState");

                entity.Property(e => e.TravelAttrTravelCode).HasColumnName("TravelAttr_TravelCode");

                entity.Property(e => e.TravelAttrVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("TravelAttr_VarParamA");

                entity.Property(e => e.TravelAttrVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("TravelAttr_VarParamB");
            });

            modelBuilder.Entity<TwebTravelprodlist>(entity =>
            {
                entity.HasKey(e => e.TravelProdListId)
                    .HasName("PRIMARY");

                entity.ToTable("tweb_travelprodlist");

                entity.Property(e => e.TravelProdListId).HasColumnName("TravelProdList_ID");

                entity.Property(e => e.TravelProdListFloatParamA).HasColumnName("TravelProdList_FloatParamA");

                entity.Property(e => e.TravelProdListFloatParamB).HasColumnName("TravelProdList_FloatParamB");

                entity.Property(e => e.TravelProdListIntParamA).HasColumnName("TravelProdList_IntParamA");

                entity.Property(e => e.TravelProdListIntParamB).HasColumnName("TravelProdList_IntParamB");

                entity.Property(e => e.TravelProdListProdListCode).HasColumnName("TravelProdList_ProdListCode");

                entity.Property(e => e.TravelProdListSyncState).HasColumnName("TravelProdList_SyncState");

                entity.Property(e => e.TravelProdListTravelCode).HasColumnName("TravelProdList_TravelCode");

                entity.Property(e => e.TravelProdListVarParamA)
                    .HasColumnType("text")
                    .HasColumnName("TravelProdList_VarParamA");

                entity.Property(e => e.TravelProdListVarParamB)
                    .HasColumnType("text")
                    .HasColumnName("TravelProdList_VarParamB");
            });

            modelBuilder.Entity<ViewCardlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_cardlist");

                entity.Property(e => e.MaxUserCardChangeLogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("maxUserCardChangeLog_Date");

                entity.Property(e => e.UserFavouriteText2)
                    .HasMaxLength(50)
                    .HasColumnName("UserFavourite_Text2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.UserFavouriteTypeCode).HasColumnName("UserFavourite_TypeCode");

                entity.Property(e => e.UserFavouriteUserInfoCode).HasColumnName("UserFavourite_UserInfoCode");
            });

            modelBuilder.Entity<ViewIteminfopart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_iteminfopart");

                entity.Property(e => e.ItemInfoPartAmount).HasColumnName("ItemInfoPart_Amount");

                entity.Property(e => e.ItemInfoPartAttributeValueCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueCode")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_AttributeValueName")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartCartCode).HasColumnName("ItemInfoPart_CartCode");

                entity.Property(e => e.ItemInfoPartChangeAmount).HasColumnName("ItemInfoPart_ChangeAmount");

                entity.Property(e => e.ItemInfoPartChangeQty).HasColumnName("ItemInfoPart_ChangeQTY");

                entity.Property(e => e.ItemInfoPartCost).HasColumnName("ItemInfoPart_Cost");

                entity.Property(e => e.ItemInfoPartDealState).HasColumnName("ItemInfoPart_DealState");

                entity.Property(e => e.ItemInfoPartEcstoreCode).HasColumnName("ItemInfoPart_ECStoreCode");

                entity.Property(e => e.ItemInfoPartFloatParamA).HasColumnName("ItemInfoPart_FloatParamA");

                entity.Property(e => e.ItemInfoPartFloatParamB).HasColumnName("ItemInfoPart_FloatParamB");

                entity.Property(e => e.ItemInfoPartId).HasColumnName("ItemInfoPart_ID");

                entity.Property(e => e.ItemInfoPartIntParamA).HasColumnName("ItemInfoPart_IntParamA");

                entity.Property(e => e.ItemInfoPartIntParamB).HasColumnName("ItemInfoPart_IntParamB");

                entity.Property(e => e.ItemInfoPartItemCode).HasColumnName("ItemInfoPart_ItemCode");

                entity.Property(e => e.ItemInfoPartItemId).HasColumnName("ItemInfoPart_ItemID");

                entity.Property(e => e.ItemInfoPartItemMsg)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_ItemMsg")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ItemInfoPart_ItemName")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartNoTax).HasColumnName("ItemInfoPart_NoTax");

                entity.Property(e => e.ItemInfoPartOtherCode).HasColumnName("ItemInfoPart_OtherCode");

                entity.Property(e => e.ItemInfoPartParamQty).HasColumnName("ItemInfoPart_ParamQTY");

                entity.Property(e => e.ItemInfoPartPayAmount).HasColumnName("ItemInfoPart_PayAmount");

                entity.Property(e => e.ItemInfoPartQuantity).HasColumnName("ItemInfoPart_Quantity");

                entity.Property(e => e.ItemInfoPartReceiptPrice).HasColumnName("ItemInfoPart_ReceiptPrice");

                entity.Property(e => e.ItemInfoPartReceiptText)
                    .HasMaxLength(10)
                    .HasColumnName("ItemInfoPart_ReceiptText")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartShareQty).HasColumnName("ItemInfoPart_ShareQTY");

                entity.Property(e => e.ItemInfoPartState).HasColumnName("ItemInfoPart_State");

                entity.Property(e => e.ItemInfoPartSupplierCode).HasColumnName("ItemInfoPart_SupplierCode");

                entity.Property(e => e.ItemInfoPartSyncState).HasColumnName("ItemInfoPart_SyncState");

                entity.Property(e => e.ItemInfoPartTableNo).HasColumnName("ItemInfoPart_TableNo");

                entity.Property(e => e.ItemInfoPartTax).HasColumnName("ItemInfoPart_Tax");

                entity.Property(e => e.ItemInfoPartTrueAmount).HasColumnName("ItemInfoPart_TrueAmount");

                entity.Property(e => e.ItemInfoPartType).HasColumnName("ItemInfoPart_Type");

                entity.Property(e => e.ItemInfoPartUpTableNo).HasColumnName("ItemInfoPart_UpTableNo");

                entity.Property(e => e.ItemInfoPartUserDefineCode).HasColumnName("ItemInfoPart_UserDefineCode");

                entity.Property(e => e.ItemInfoPartUserDefineName)
                    .HasMaxLength(64)
                    .HasColumnName("ItemInfoPart_UserDefineName")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ItemInfoPartVarParamA)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ItemInfoPart_VarParamA")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ItemInfoPartVarParamB)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ItemInfoPart_VarParamB")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ItemInfoPartVoucherCode)
                    .HasMaxLength(500)
                    .HasColumnName("ItemInfoPart_VoucherCode")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<ViewLatestpayorderlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_latestpayorderlog");

                entity.Property(e => e.PayOrderLogPayActionState).HasColumnName("PayOrderLog_PayActionState");

                entity.Property(e => e.PayOrderLogPayOrderTableNo).HasColumnName("PayOrderLog_PayOrderTableNo");
            });

            modelBuilder.Entity<ViewLatestservice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_latestservices");

                entity.Property(e => e.ServicesHandleState).HasColumnName("Services_HandleState");

                entity.Property(e => e.ServicesOrderTableNo).HasColumnName("Services_OrderTableNo");
            });

            modelBuilder.Entity<ViewUsermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_usermission");

                entity.Property(e => e.UserMissionAmountPoint).HasColumnName("UserMission_AmountPoint");

                entity.Property(e => e.UserMissionCompleteCount).HasColumnName("UserMission_CompleteCount");

                entity.Property(e => e.UserMissionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_Date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserMissionFreqCount).HasColumnName("UserMission_FreqCount");

                entity.Property(e => e.UserMissionId).HasColumnName("UserMission_ID");

                entity.Property(e => e.UserMissionIsReleased).HasColumnName("UserMission_IsReleased");

                entity.Property(e => e.UserMissionMissionCode).HasColumnName("UserMission_MissionCode");

                entity.Property(e => e.UserMissionRelLimtDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_RelLimtDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserMissionReleasedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_ReleasedDate");

                entity.Property(e => e.UserMissionState).HasColumnName("UserMission_State");

                entity.Property(e => e.UserMissionUpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserMission_UpdateDate");

                entity.Property(e => e.UserMissionUserInfoCode).HasColumnName("UserMission_UserInfoCode");
            });

            modelBuilder.Entity<ViewUservoucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_uservoucher");

                entity.Property(e => e.UserVoucherCode).HasColumnName("UserVoucher_Code");

                entity.Property(e => e.UserVoucherFloatParamA).HasColumnName("UserVoucher_FloatParamA");

                entity.Property(e => e.UserVoucherFloatParamB).HasColumnName("UserVoucher_FloatParamB");

                entity.Property(e => e.UserVoucherId).HasColumnName("UserVoucher_ID");

                entity.Property(e => e.UserVoucherIntParamA).HasColumnName("UserVoucher_IntParamA");

                entity.Property(e => e.UserVoucherIntParamB).HasColumnName("UserVoucher_IntParamB");

                entity.Property(e => e.UserVoucherPayOrderTableNo).HasColumnName("UserVoucher_PayOrderTableNo");

                entity.Property(e => e.UserVoucherQrcode)
                    .HasColumnType("mediumtext")
                    .HasColumnName("UserVoucher_QRCode")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserVoucherReceiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_ReceiveDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserVoucherState).HasColumnName("UserVoucher_State");

                entity.Property(e => e.UserVoucherSyncState).HasColumnName("UserVoucher_SyncState");

                entity.Property(e => e.UserVoucherTableNo).HasColumnName("UserVoucher_TableNo");

                entity.Property(e => e.UserVoucherUsedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedDate");

                entity.Property(e => e.UserVoucherUsedEcstore).HasColumnName("UserVoucher_UsedECStore");

                entity.Property(e => e.UserVoucherUsedOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOffDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserVoucherUsedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UserVoucher_UsedOnDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserVoucherUsedState).HasColumnName("UserVoucher_UsedState");

                entity.Property(e => e.UserVoucherUsedType).HasColumnName("UserVoucher_UsedType");

                entity.Property(e => e.UserVoucherUserInfoCode).HasColumnName("UserVoucher_UserInfoCode");

                entity.Property(e => e.UserVoucherVarParamA)
                    .HasColumnType("mediumtext")
                    .HasColumnName("UserVoucher_VarParamA")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserVoucherVarParamB)
                    .HasColumnType("mediumtext")
                    .HasColumnName("UserVoucher_VarParamB")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserVoucherVoucherCode).HasColumnName("UserVoucher_VoucherCode");

                entity.Property(e => e.UserVoucherVoucherLimitId).HasColumnName("UserVoucher_VoucherLimitID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
