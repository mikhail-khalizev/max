using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7cd1-2d2fcd03")]
        public void Method_1008_7cd1()
        {
            ii(0x1008_7cd1, 5); push(0x20);                             /* push 0x20 */
            ii(0x1008_7cd6, 5); call(Definitions.sys_check_available_stack_size, 0xd_e077); /* call 0x10165d52 */
            ii(0x1008_7cdb, 1); push(ebx);                              /* push ebx */
            ii(0x1008_7cdc, 1); push(ecx);                              /* push ecx */
            ii(0x1008_7cdd, 1); push(esi);                              /* push esi */
            ii(0x1008_7cde, 1); push(edi);                              /* push edi */
            ii(0x1008_7cdf, 1); push(ebp);                              /* push ebp */
            ii(0x1008_7ce0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7ce2, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_7ce8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_7ceb, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_7cee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7cf0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7cf3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7cf6, 5); call(0x1013_ad11, 0xb_3016);            /* call 0x1013ad11 */
            ii(0x1008_7cfb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7cfd, 2); if(jz(0x1008_7d0f, 0x10)) goto l_0x1008_7d0f; /* jz 0x10087d0f */
            ii(0x1008_7cff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_7d02, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1008_7d06, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7d09, 4); cmp(dx, memw[ds, eax + 0x1b]);          /* cmp dx, [eax+0x1b] */
            ii(0x1008_7d0d, 2); if(jz(0x1008_7d11, 2)) goto l_0x1008_7d11; /* jz 0x10087d11 */
        l_0x1008_7d0f:
            ii(0x1008_7d0f, 2); jmp(0x1008_7d22, 0x11); goto l_0x1008_7d22; /* jmp 0x10087d22 */
        l_0x1008_7d11:
            ii(0x1008_7d11, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7d13, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7d16, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7d19, 5); call(0x1013_ad71, 0xb_3053);            /* call 0x1013ad71 */
            ii(0x1008_7d1e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7d20, 2); if(jnz(0x1008_7d24, 2)) goto l_0x1008_7d24; /* jnz 0x10087d24 */
        l_0x1008_7d22:
            ii(0x1008_7d22, 2); jmp(0x1008_7d61, 0x3d); goto l_0x1008_7d61; /* jmp 0x10087d61 */
        l_0x1008_7d24:
            ii(0x1008_7d24, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_7d27, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7d2a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7d2d, 5); call(0x1007_6630, -0x1_1702);           /* call 0x10076630 */
            ii(0x1008_7d32, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1008_7d35, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7d38, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7d3b, 5); call(0x1007_6574, -0x1_17cc);           /* call 0x10076574 */
            ii(0x1008_7d40, 5); call(0x1015_27ed, 0xc_aaa8);            /* call 0x101527ed */
            ii(0x1008_7d45, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_7d4a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7d4d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7d50, 5); call(0x1007_6574, -0x1_17e1);           /* call 0x10076574 */
            ii(0x1008_7d55, 5); call(0x1015_2605, 0xc_a8ab);            /* call 0x10152605 */
            ii(0x1008_7d5a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_7d5d, 4); mov(memb[ds, eax + 0x1d], 0);           /* mov byte [eax+0x1d], 0x0 */
        l_0x1008_7d61:
            ii(0x1008_7d61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7d63, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_7d64, 1); pop(edi);                               /* pop edi */
            ii(0x1008_7d65, 1); pop(esi);                               /* pop esi */
            ii(0x1008_7d66, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_7d67, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7d68, 1); ret();                                  /* ret */
        }
    }
}
