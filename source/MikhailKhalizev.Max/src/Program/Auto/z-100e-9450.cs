using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9450-b0aac18")]
        public void Method_100e_9450()
        {
            ii(0x100e_9450, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_9455, 5); call(Definitions.sys_check_available_stack_size, 0x7_c8f8); /* call 0x10165d52 */
            ii(0x100e_945a, 1); push(ebx);                              /* push ebx */
            ii(0x100e_945b, 1); push(ecx);                              /* push ecx */
            ii(0x100e_945c, 1); push(esi);                              /* push esi */
            ii(0x100e_945d, 1); push(edi);                              /* push edi */
            ii(0x100e_945e, 1); push(ebp);                              /* push ebp */
            ii(0x100e_945f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9461, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_9467, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_946a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_946d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9470, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100e_9473, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9476, 4); cmp(dx, memw[ds, eax + 2]);             /* cmp dx, [eax+0x2] */
            ii(0x100e_947a, 2); if(jnz(0x100e_94cb, 0x4f)) goto l_0x100e_94cb; /* jnz 0x100e94cb */
            ii(0x100e_947c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_947f, 4); add(memw[ds, eax], 5);                  /* add word [eax], 0x5 */
            ii(0x100e_9483, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9486, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100e_9489, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100e_948c, 5); call(Definitions.sys_new_arr, 0x7_cb7f); /* call 0x10166010 */
            ii(0x100e_9491, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_9494, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_9497, 5); cmp(memw[ds, eax + 2], 0);              /* cmp word [eax+0x2], 0x0 */
            ii(0x100e_949c, 2); if(jz(0x100e_94c2, 0x24)) goto l_0x100e_94c2; /* jz 0x100e94c2 */
            ii(0x100e_949e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_94a1, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x100e_94a3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_94a6, 3); shl(ebx, 2);                            /* shl ebx, 0x2 */
            ii(0x100e_94a9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_94ac, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x100e_94af, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_94b2, 5); call(Definitions.sys_memcpy, 0x7_c994); /* call 0x10165e4b */
            ii(0x100e_94b7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_94ba, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100e_94bd, 5); call(Definitions.sys_free, 0x8_1bff);   /* call 0x1016b0c1 */
        l_0x100e_94c2:
            ii(0x100e_94c2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_94c5, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100e_94c8, 3); mov(memd[ds, edx + 4], eax);            /* mov [edx+0x4], eax */
        l_0x100e_94cb:
            ii(0x100e_94cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_94ce, 4); mov(dx, memw[ds, eax + 2]);             /* mov dx, [eax+0x2] */
            ii(0x100e_94d2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_94d5, 4); inc(memw[ds, eax + 2]);                 /* inc word [eax+0x2] */
            ii(0x100e_94d9, 3); movsx(eax, dx);                         /* movsx eax, dx */
            ii(0x100e_94dc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100e_94df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_94e1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_94e4, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100e_94e7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_94e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_94ec, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x100e_94ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_94f0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_94f1, 1); pop(edi);                               /* pop edi */
            ii(0x100e_94f2, 1); pop(esi);                               /* pop esi */
            ii(0x100e_94f3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_94f4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_94f5, 1); ret();                                  /* ret */
        }
    }
}
