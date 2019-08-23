using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_fca3-74944aaf")]
        public void Method_100f_fca3()
        {
            ii(0x100f_fca3, 5); push(0x30);                             /* push 0x30 */
            ii(0x100f_fca8, 5); call(Definitions.sys_check_available_stack_size, 0x6_60a5); /* call 0x10165d52 */
            ii(0x100f_fcad, 1); push(ecx);                              /* push ecx */
            ii(0x100f_fcae, 1); push(esi);                              /* push esi */
            ii(0x100f_fcaf, 1); push(edi);                              /* push edi */
            ii(0x100f_fcb0, 1); push(ebp);                              /* push ebp */
            ii(0x100f_fcb1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_fcb3, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_fcb9, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_fcbc, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100f_fcbf, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100f_fcc2, 4); movsx(eax, memb[ss, ebp - 0x4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_fcc6, 5); call(0x100e_883d, -0x1_748e);           /* call 0x100e883d */
            ii(0x100f_fccb, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_fcce, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_fcd1, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x100f_fcd4, 2); jmp(0x100f_fd2a, 0x54); goto l_0x100f_fd2a; /* jmp 0x100ffd2a */
        l_0x100f_fcd6:
            ii(0x100f_fcd6, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_fcd9, 5); mov(eax, memd[ds, 0x101b_8962]);        /* mov eax, [0x101b8962] */
            ii(0x100f_fcde, 5); call(0x100d_7f6c, -0x2_7d77);           /* call 0x100d7f6c */
            ii(0x100f_fce3, 2); jmp(0x100f_fd46, 0x61); goto l_0x100f_fd46; /* jmp 0x100ffd46 */
        l_0x100f_fce5:
            ii(0x100f_fce5, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_fce8, 5); mov(eax, memd[ds, 0x101b_8974]);        /* mov eax, [0x101b8974] */
            ii(0x100f_fced, 5); call(0x100d_7f6c, -0x2_7d86);           /* call 0x100d7f6c */
            ii(0x100f_fcf2, 2); jmp(0x100f_fd46, 0x52); goto l_0x100f_fd46; /* jmp 0x100ffd46 */
        l_0x100f_fcf4:
            ii(0x100f_fcf4, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_fcf8, 1); push(eax);                              /* push eax */
            ii(0x100f_fcf9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_fcfc, 3); mov(ecx, memd[ds, eax + 0xe]);          /* mov ecx, [eax+0xe] */
            ii(0x100f_fcff, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_fd02, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_fd05, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100f_fd08, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_fd0b, 3); sub(eax, memd[ds, edx + 0x4]);          /* sub eax, [edx+0x4] */
            ii(0x100f_fd0e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_fd10, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_fd13, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_fd16, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_fd19, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100f_fd1b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_fd1d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_fd20, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_fd23, 5); call(/* sys */ 0x1016_ad78, 0x6_b050);  /* call 0x1016ad78 */
            ii(0x100f_fd28, 2); jmp(0x100f_fd46, 0x1c); goto l_0x100f_fd46; /* jmp 0x100ffd46 */
        l_0x100f_fd2a:
            ii(0x100f_fd2a, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x100f_fd2d, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x100f_fd30, 4); cmp(memb[ss, ebp - 0x18], 0x6);         /* cmp byte [ebp-0x18], 0x6 */
            ii(0x100f_fd34, 2); if(jb(0x100f_fd44, 0xe)) goto l_0x100f_fd44; /* jb 0x100ffd44 */
            ii(0x100f_fd36, 4); cmp(memb[ss, ebp - 0x18], 0x6);         /* cmp byte [ebp-0x18], 0x6 */
            ii(0x100f_fd3a, 2); if(jbe(0x100f_fcd6, -0x66)) goto l_0x100f_fcd6; /* jbe 0x100ffcd6 */
            ii(0x100f_fd3c, 4); cmp(memb[ss, ebp - 0x18], 0x9);         /* cmp byte [ebp-0x18], 0x9 */
            ii(0x100f_fd40, 2); if(jz(0x100f_fce5, -0x5d)) goto l_0x100f_fce5; /* jz 0x100ffce5 */
            ii(0x100f_fd42, 2); jmp(0x100f_fcf4, -0x50); goto l_0x100f_fcf4; /* jmp 0x100ffcf4 */
        l_0x100f_fd44:
            ii(0x100f_fd44, 2); jmp(0x100f_fcf4, -0x52); goto l_0x100f_fcf4; /* jmp 0x100ffcf4 */
        l_0x100f_fd46:
            ii(0x100f_fd46, 5); cmp(memw[ss, ebp - 0x8], 0);            /* cmp word [ebp-0x8], 0x0 */
            ii(0x100f_fd4b, 2); if(jz(0x100f_fd5b, 0xe)) goto l_0x100f_fd5b; /* jz 0x100ffd5b */
            ii(0x100f_fd4d, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_fd50, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_fd53, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100f_fd56, 5); call(Definitions.sys_display_draw_1, 0x6_774d); /* call 0x101674a8 */
        l_0x100f_fd5b:
            ii(0x100f_fd5b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_fd5d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_fd5e, 1); pop(edi);                               /* pop edi */
            ii(0x100f_fd5f, 1); pop(esi);                               /* pop esi */
            ii(0x100f_fd60, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_fd61, 1); ret();                                  /* ret */
        }
    }
}
