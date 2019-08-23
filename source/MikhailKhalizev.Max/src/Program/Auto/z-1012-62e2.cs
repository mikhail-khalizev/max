using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_62e2-c6a68787")]
        public void Method_1012_62e2()
        {
            ii(0x1012_62e2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_62e7, 5); calld(Definitions.sys_check_available_stack_size, 0x3_fa66); /* call 0x10165d52 */
            ii(0x1012_62ec, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_62ed, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_62ee, 1); pushd(esi);                             /* push esi */
            ii(0x1012_62ef, 1); pushd(edi);                             /* push edi */
            ii(0x1012_62f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_62f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_62f3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_62f9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_62fc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_62ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_6302, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_6305, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_6308, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_630b, 5); calld(0x1012_6202, -0x10e);             /* call 0x10126202 */
            ii(0x1012_6310, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6313, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6315, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x1012_6318, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_631b, 4); mov(memw_a32[ds, eax + 0x11], dx);      /* mov [eax+0x11], dx */
            ii(0x1012_631f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6322, 5); calld(0x1009_c9a0, -0x8_9987);          /* call 0x1009c9a0 */
            ii(0x1012_6327, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_6329, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_632c, 4); mov(memw_a32[ds, eax + 0x13], dx);      /* mov [eax+0x13], dx */
            ii(0x1012_6330, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6333, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1012_6337, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_633a, 4); mov(memw_a32[ds, eax + 0x15], dx);      /* mov [eax+0x15], dx */
            ii(0x1012_633e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6341, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6343, 3); mov(dl, memb_a32[ds, eax + 0x27]);      /* mov dl, [eax+0x27] */
            ii(0x1012_6346, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6349, 4); mov(memw_a32[ds, eax + 0x17], dx);      /* mov [eax+0x17], dx */
            ii(0x1012_634d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6350, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6352, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_6355, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6358, 4); mov(memw_a32[ds, eax + 0x1d], dx);      /* mov [eax+0x1d], dx */
            ii(0x1012_635c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_635f, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1012_6363, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6366, 4); mov(memw_a32[ds, eax + 0x19], dx);      /* mov [eax+0x19], dx */
            ii(0x1012_636a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_636d, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1012_6371, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6374, 4); mov(memw_a32[ds, eax + 0x1b], dx);      /* mov [eax+0x1b], dx */
            ii(0x1012_6378, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_637b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_637d, 3); mov(dl, memb_a32[ds, eax + 0x4d]);      /* mov dl, [eax+0x4d] */
            ii(0x1012_6380, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6383, 4); mov(memw_a32[ds, eax + 0x1f], dx);      /* mov [eax+0x1f], dx */
            ii(0x1012_6387, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_638a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_638c, 3); mov(dl, memb_a32[ds, eax + 0x4e]);      /* mov dl, [eax+0x4e] */
            ii(0x1012_638f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6392, 4); mov(memw_a32[ds, eax + 0x21], dx);      /* mov [eax+0x21], dx */
            ii(0x1012_6396, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_6399, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_639b, 3); mov(al, memb_a32[ds, edx + 0x50]);      /* mov al, [edx+0x50] */
            ii(0x1012_639e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_63a1, 4); mov(memw_a32[ds, edx + 0x23], ax);      /* mov [edx+0x23], ax */
            ii(0x1012_63a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_63a8, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1012_63ac, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_63af, 4); mov(memw_a32[ds, edx + 0x25], ax);      /* mov [edx+0x25], ax */
            ii(0x1012_63b3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_63b6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_63b8, 3); mov(al, memb_a32[ds, edx + 0x54]);      /* mov al, [edx+0x54] */
            ii(0x1012_63bb, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_63be, 4); mov(memw_a32[ds, edx + 0x27], ax);      /* mov [edx+0x27], ax */
            ii(0x1012_63c2, 7); mov(memd_a32[ss, ebp - 0xc], 0x29);     /* mov dword [ebp-0xc], 0x29 */
            ii(0x1012_63c9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_63cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_63ce, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_63cf, 1); popd(edi);                              /* pop edi */
            ii(0x1012_63d0, 1); popd(esi);                              /* pop esi */
            ii(0x1012_63d1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_63d2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_63d3, 1); retd();                                 /* ret */
        }
    }
}
