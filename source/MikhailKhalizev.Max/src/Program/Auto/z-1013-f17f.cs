using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f17f-3062fd5d")]
        public void Method_1013_f17f()
        {
            ii(0x1013_f17f, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_f184, 5); call(Definitions.sys_check_available_stack_size, 0x2_6bc9); /* call 0x10165d52 */
            ii(0x1013_f189, 1); push(esi);                              /* push esi */
            ii(0x1013_f18a, 1); push(edi);                              /* push edi */
            ii(0x1013_f18b, 1); push(ebp);                              /* push ebp */
            ii(0x1013_f18c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_f18e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_f194, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_f197, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_f19a, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_f19d, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1013_f1a0, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1013_f1a5, 5); call(Definitions.sys_new, 0x2_6c56);    /* call 0x10165e00 */
            ii(0x1013_f1aa, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_f1ad, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1013_f1b2, 5); call(Definitions.sys_new, 0x2_6c49);    /* call 0x10165e00 */
            ii(0x1013_f1b7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_f1b9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f1bc, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1013_f1be, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f1c1, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_f1c3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_f1c6, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1013_f1c9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f1cc, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_f1ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f1d1, 3); mov(memd[ds, edx + 0x2], eax);          /* mov [edx+0x2], eax */
            ii(0x1013_f1d4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f1d7, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_f1d9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_f1dc, 3); mov(memd[ds, edx + 0x6], eax);          /* mov [edx+0x6], eax */
            ii(0x1013_f1df, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f1e2, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_f1e4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f1e7, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x1013_f1ea, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f1ed, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_f1f0, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1013_f1f2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_f1f5, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_f1f8, 3); add(memd[ds, edx + 0x4], eax);          /* add [edx+0x4], eax */
        l_0x1013_f1fb:
            ii(0x1013_f1fb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f1fe, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x1013_f201, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f204, 3); cmp(edx, memd[ds, eax + 0x8]);          /* cmp edx, [eax+0x8] */
            ii(0x1013_f207, 2); if(jle(0x1013_f254, 0x4b)) goto l_0x1013_f254; /* jle 0x1013f254 */
            ii(0x1013_f209, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f20c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_f20e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x1013_f211:
            ii(0x1013_f211, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f214, 4); cmp(memd[ds, eax + 0x4], 0);            /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_f218, 2); if(jz(0x1013_f225, 0xb)) goto l_0x1013_f225; /* jz 0x1013f225 */
            ii(0x1013_f21a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f21d, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1013_f220, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_f223, 2); jmp(0x1013_f211, -0x14); goto l_0x1013_f211; /* jmp 0x1013f211 */
        l_0x1013_f225:
            ii(0x1013_f225, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f228, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_f22a, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1013_f22d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_f230, 3); sub(memd[ds, eax + 0x4], edx);          /* sub [eax+0x4], edx */
            ii(0x1013_f233, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f236, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_f238, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1013_f23b, 5); call(Definitions.sys_delete, 0x2_6d24); /* call 0x10165f64 */
            ii(0x1013_f240, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f243, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_f245, 5); call(Definitions.sys_delete, 0x2_6d1a); /* call 0x10165f64 */
            ii(0x1013_f24a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f24d, 5); call(Definitions.sys_delete, 0x2_6d12); /* call 0x10165f64 */
            ii(0x1013_f252, 2); jmp(0x1013_f1fb, -0x59); goto l_0x1013_f1fb; /* jmp 0x1013f1fb */
        l_0x1013_f254:
            ii(0x1013_f254, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f256, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_f257, 1); pop(edi);                               /* pop edi */
            ii(0x1013_f258, 1); pop(esi);                               /* pop esi */
            ii(0x1013_f259, 1); ret();                                  /* ret */
        }
    }
}
