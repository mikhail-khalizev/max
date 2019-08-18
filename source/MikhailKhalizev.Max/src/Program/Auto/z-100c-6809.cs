using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6809-4d37a101")]
        public void Method_100c_6809()
        {
            ii(0x100c_6809, 1); hlt();                                  /* hlt */
            ii(0x100c_680a, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_680d, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x100c_6812, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6815, 5); calld(0x100c_6542, -0x2d8);             /* call 0x100c6542 */
            ii(0x100c_681a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_681f, 1); pushd(eax);                             /* push eax */
            ii(0x100c_6820, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_6823, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_6826, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_6829, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_682c, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_682f, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6834, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6837, 5); calld(0x100c_6542, -0x2fa);             /* call 0x100c6542 */
            ii(0x100c_683c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_6841, 1); pushd(eax);                             /* push eax */
            ii(0x100c_6842, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x100c_6845, 3); mov(ecx, memd_a32[ds, ecx + 0x79]);     /* mov ecx, [ecx+0x79] */
            ii(0x100c_6848, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_684b, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100c_684e, 3); movsx(ebx, memw_a32[ds, ebx]);          /* movsx ebx, word [ebx] */
            ii(0x100c_6851, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_6856, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6859, 5); calld(0x100c_6542, -0x31c);             /* call 0x100c6542 */
            ii(0x100c_685e, 5); mov(edx, 0x43);                         /* mov edx, 0x43 */
            ii(0x100c_6863, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6866, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_6869, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_686c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_6872, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100c_6877, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_6879, 5); calld(0x100d_fd2c, 0x1_94ae);           /* call 0x100dfd2c */
            ii(0x100c_687e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_6880, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100c_6885, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6888, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_688b, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x100c_6891, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x100c_6896, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_6898, 5); calld(0x100d_fd2c, 0x1_948f);           /* call 0x100dfd2c */
            ii(0x100c_689d, 4); mov(dx, memw_a32[ds, ebx + 0x17]);      /* mov dx, [ebx+0x17] */
            ii(0x100c_68a1, 4); cmp(dx, memw_a32[ds, eax + 0x17]);      /* cmp dx, [eax+0x17] */
            ii(0x100c_68a5, 2); if(jld(0x100c_68b9, 0x12)) goto l_0x100c_68b9; /* jl 0x100c68b9 */
            ii(0x100c_68a7, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_68ac, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100c_68b1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_68b4, 5); calld(0x100c_64f5, -0x3c4);             /* call 0x100c64f5 */
        l_0x100c_68b9:
            ii(0x100c_68b9, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_68be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_68c1, 3); mov(eax, memd_a32[ds, eax + 0x79]);     /* mov eax, [eax+0x79] */
            ii(0x100c_68c4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_68c7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_68cd, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x100c_68d2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_68d4, 5); calld(0x100d_fd2c, 0x1_9453);           /* call 0x100dfd2c */
            ii(0x100c_68d9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_68db, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_68e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_68e3, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_68e6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_68ec, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x100c_68f1, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_68f3, 5); calld(0x100d_fd2c, 0x1_9434);           /* call 0x100dfd2c */
            ii(0x100c_68f8, 4); mov(dx, memw_a32[ds, ebx + 0x17]);      /* mov dx, [ebx+0x17] */
            ii(0x100c_68fc, 4); cmp(dx, memw_a32[ds, eax + 0x17]);      /* cmp dx, [eax+0x17] */
            ii(0x100c_6900, 2); if(jld(0x100c_6914, 0x12)) goto l_0x100c_6914; /* jl 0x100c6914 */
            ii(0x100c_6902, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6907, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_690c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_690f, 5); calld(0x100c_64f5, -0x41f);             /* call 0x100c64f5 */
        l_0x100c_6914:
            ii(0x100c_6914, 5); calld(0x100c_aef4, 0x45db);             /* call 0x100caef4 */
            ii(0x100c_6919, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_691b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_691d, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_6920, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_6923, 5); calld(0x100c_ae64, 0x453c);             /* call 0x100cae64 */
            ii(0x100c_6928, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_692a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_692d, 5); calld(0x100c_7177, 0x845);              /* call 0x100c7177 */
            ii(0x100c_6932, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_6934, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_6937, 5); calld(0x100c_a6a0, 0x3d64);             /* call 0x100ca6a0 */
        }
    }
}
