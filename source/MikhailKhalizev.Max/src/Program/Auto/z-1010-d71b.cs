using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d71b-ecdba554")]
        public void Method_1010_d71b()
        {
            ii(0x1010_d71b, 5); push(0x30);                             /* push 0x30 */
            ii(0x1010_d720, 5); call(Definitions.sys_check_available_stack_size, 0x5_862d); /* call 0x10165d52 */
            ii(0x1010_d725, 1); push(ebx);                              /* push ebx */
            ii(0x1010_d726, 1); push(ecx);                              /* push ecx */
            ii(0x1010_d727, 1); push(edx);                              /* push edx */
            ii(0x1010_d728, 1); push(esi);                              /* push esi */
            ii(0x1010_d729, 1); push(edi);                              /* push edi */
            ii(0x1010_d72a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_d72b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d72d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_d733, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_d736, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_d738, 5); call(0x100e_883d, -0x2_4f00);           /* call 0x100e883d */
            ii(0x1010_d73d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_d73f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d742, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1010_d744, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d747, 7); mov(memd[ds, eax + 4], 0);              /* mov dword [eax+0x4], 0x0 */
            ii(0x1010_d74e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d751, 7); mov(memd[ds, eax + 8], 0);              /* mov dword [eax+0x8], 0x0 */
            ii(0x1010_d758, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d75b, 7); mov(memd[ds, eax + 28], 0);             /* mov dword [eax+0x1c], 0x0 */
            ii(0x1010_d762, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d765, 7); mov(memd[ds, eax + 20], 0);             /* mov dword [eax+0x14], 0x0 */
            ii(0x1010_d76c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d76f, 7); mov(memd[ds, eax + 24], 0);             /* mov dword [eax+0x18], 0x0 */
            ii(0x1010_d776, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1010_d77b, 5); call(0x1007_5fdc, -0x9_77a4);           /* call 0x10075fdc */
            ii(0x1010_d780, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_d782, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d785, 4); mov(memw[ds, eax + 12], dx);            /* mov [eax+0xc], dx */
            ii(0x1010_d789, 5); call(/* sys */ 0x1016_be34, 0x5_e6a6);  /* call 0x1016be34 */
            ii(0x1010_d78e, 7); mov(memd[ss, ebp - 8], 0xc);            /* mov dword [ebp-0x8], 0xc */
        l_0x1010_d795:
            ii(0x1010_d795, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1010_d798, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_d79d, 2); if(jz(0x1010_d7ad, 0xe)) goto l_0x1010_d7ad; /* jz 0x1010d7ad */
            ii(0x1010_d79f, 4); movsx(edx, memb[ss, ebp - 8]);          /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_d7a3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d7a6, 5); call(0x1010_d407, -0x3a4);              /* call 0x1010d407 */
            ii(0x1010_d7ab, 2); jmp(0x1010_d795, -0x18); goto l_0x1010_d795; /* jmp 0x1010d795 */
        l_0x1010_d7ad:
            ii(0x1010_d7ad, 5); call(0x100d_533c, -0x3_8476);           /* call 0x100d533c */
            ii(0x1010_d7b2, 1); cwde();                                 /* cwde */
            ii(0x1010_d7b3, 1); push(eax);                              /* push eax */
            ii(0x1010_d7b4, 5); call(0x100d_5360, -0x3_8459);           /* call 0x100d5360 */
            ii(0x1010_d7b9, 1); cwde();                                 /* cwde */
            ii(0x1010_d7ba, 1); push(eax);                              /* push eax */
            ii(0x1010_d7bb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_d7bd, 1); push(eax);                              /* push eax */
            ii(0x1010_d7be, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d7c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d7c3, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d7c5, 3); mov(ebx, memd[ds, eax + 14]);           /* mov ebx, [eax+0xe] */
            ii(0x1010_d7c8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_d7cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d7ce, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_d7d0, 5); mov(eax, 0x6cf);                        /* mov eax, 0x6cf */
            ii(0x1010_d7d5, 5); call(0x100e_8c51, -0x2_4b89);           /* call 0x100e8c51 */
            ii(0x1010_d7da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_d7dc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d7df, 5); call(0x1010_ca8c, -0xd58);              /* call 0x1010ca8c */
            ii(0x1010_d7e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_d7e7, 5); call(0x1010_cca5, -0xb47);              /* call 0x1010cca5 */
            ii(0x1010_d7ec, 5); call(/* sys */ 0x1016_bcc4, 0x5_e4d3);  /* call 0x1016bcc4 */
            ii(0x1010_d7f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d7f3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_d7f4, 1); pop(edi);                               /* pop edi */
            ii(0x1010_d7f5, 1); pop(esi);                               /* pop esi */
            ii(0x1010_d7f6, 1); pop(edx);                               /* pop edx */
            ii(0x1010_d7f7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_d7f8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_d7f9, 1); ret();                                  /* ret */
        }
    }
}
