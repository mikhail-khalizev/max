using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_62e2-c6a68787")]
        public void Method_1012_62e2()
        {
            ii(0x1012_62e2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_62e7, 5); call(Definitions.sys_check_available_stack_size, 0x3_fa66); /* call 0x10165d52 */
            ii(0x1012_62ec, 1); push(ebx);                              /* push ebx */
            ii(0x1012_62ed, 1); push(ecx);                              /* push ecx */
            ii(0x1012_62ee, 1); push(esi);                              /* push esi */
            ii(0x1012_62ef, 1); push(edi);                              /* push edi */
            ii(0x1012_62f0, 1); push(ebp);                              /* push ebp */
            ii(0x1012_62f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_62f3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_62f9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_62fc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_62ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_6302, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_6305, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_6308, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_630b, 5); call(0x1012_6202, -0x10e);              /* call 0x10126202 */
            ii(0x1012_6310, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6313, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6315, 3); mov(dl, memb[ds, eax + 69]);            /* mov dl, [eax+0x45] */
            ii(0x1012_6318, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_631b, 4); mov(memw[ds, eax + 17], dx);            /* mov [eax+0x11], dx */
            ii(0x1012_631f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6322, 5); call(0x1009_c9a0, -0x8_9987);           /* call 0x1009c9a0 */
            ii(0x1012_6327, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_6329, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_632c, 4); mov(memw[ds, eax + 19], dx);            /* mov [eax+0x13], dx */
            ii(0x1012_6330, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6333, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1012_6337, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_633a, 4); mov(memw[ds, eax + 21], dx);            /* mov [eax+0x15], dx */
            ii(0x1012_633e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6341, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6343, 3); mov(dl, memb[ds, eax + 39]);            /* mov dl, [eax+0x27] */
            ii(0x1012_6346, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_6349, 4); mov(memw[ds, eax + 23], dx);            /* mov [eax+0x17], dx */
            ii(0x1012_634d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_6350, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6352, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1012_6355, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_6358, 4); mov(memw[ds, eax + 29], dx);            /* mov [eax+0x1d], dx */
            ii(0x1012_635c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_635f, 4); mov(dx, memw[ds, eax + 26]);            /* mov dx, [eax+0x1a] */
            ii(0x1012_6363, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_6366, 4); mov(memw[ds, eax + 25], dx);            /* mov [eax+0x19], dx */
            ii(0x1012_636a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_636d, 4); mov(dx, memw[ds, eax + 28]);            /* mov dx, [eax+0x1c] */
            ii(0x1012_6371, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_6374, 4); mov(memw[ds, eax + 27], dx);            /* mov [eax+0x1b], dx */
            ii(0x1012_6378, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_637b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_637d, 3); mov(dl, memb[ds, eax + 77]);            /* mov dl, [eax+0x4d] */
            ii(0x1012_6380, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_6383, 4); mov(memw[ds, eax + 31], dx);            /* mov [eax+0x1f], dx */
            ii(0x1012_6387, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_638a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_638c, 3); mov(dl, memb[ds, eax + 78]);            /* mov dl, [eax+0x4e] */
            ii(0x1012_638f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_6392, 4); mov(memw[ds, eax + 33], dx);            /* mov [eax+0x21], dx */
            ii(0x1012_6396, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_6399, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_639b, 3); mov(al, memb[ds, edx + 80]);            /* mov al, [edx+0x50] */
            ii(0x1012_639e, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1012_63a1, 4); mov(memw[ds, edx + 35], ax);            /* mov [edx+0x23], ax */
            ii(0x1012_63a5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_63a8, 4); mov(ax, memw[ds, eax + 82]);            /* mov ax, [eax+0x52] */
            ii(0x1012_63ac, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1012_63af, 4); mov(memw[ds, edx + 37], ax);            /* mov [edx+0x25], ax */
            ii(0x1012_63b3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_63b6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_63b8, 3); mov(al, memb[ds, edx + 84]);            /* mov al, [edx+0x54] */
            ii(0x1012_63bb, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1012_63be, 4); mov(memw[ds, edx + 39], ax);            /* mov [edx+0x27], ax */
            ii(0x1012_63c2, 7); mov(memd[ss, ebp - 12], 0x29);          /* mov dword [ebp-0xc], 0x29 */
            ii(0x1012_63c9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_63cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_63ce, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_63cf, 1); pop(edi);                               /* pop edi */
            ii(0x1012_63d0, 1); pop(esi);                               /* pop esi */
            ii(0x1012_63d1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_63d2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_63d3, 1); ret();                                  /* ret */
        }
    }
}
