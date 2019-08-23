using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a2f8-b3bcc1c2")]
        public void Method_100c_a2f8()
        {
            ii(0x100c_a2f8, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_a2fd, 5); call(Definitions.sys_check_available_stack_size, 0x9_ba50); /* call 0x10165d52 */
            ii(0x100c_a302, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a303, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a304, 1); push(esi);                              /* push esi */
            ii(0x100c_a305, 1); push(edi);                              /* push edi */
            ii(0x100c_a306, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a307, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a309, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_a30f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a312, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a315, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_a318, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a31b, 5); call(0x100c_a240, -0xe0);               /* call 0x100ca240 */
            ii(0x100c_a320, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a323, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_a326, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a329, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a32c, 4); mov(dx, memw[ds, eax + 0x8]);           /* mov dx, [eax+0x8] */
            ii(0x100c_a330, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a333, 4); mov(memw[ds, eax + 0x8], dx);           /* mov [eax+0x8], dx */
            ii(0x100c_a337, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a33a, 4); mov(dx, memw[ds, eax + 0xa]);           /* mov dx, [eax+0xa] */
            ii(0x100c_a33e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a341, 4); mov(memw[ds, eax + 0xa], dx);           /* mov [eax+0xa], dx */
            ii(0x100c_a345, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a348, 4); mov(dx, memw[ds, eax + 0xc]);           /* mov dx, [eax+0xc] */
            ii(0x100c_a34c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a34f, 4); mov(memw[ds, eax + 0xc], dx);           /* mov [eax+0xc], dx */
            ii(0x100c_a353, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a356, 4); mov(dx, memw[ds, eax + 0xe]);           /* mov dx, [eax+0xe] */
            ii(0x100c_a35a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a35d, 4); mov(memw[ds, eax + 0xe], dx);           /* mov [eax+0xe], dx */
            ii(0x100c_a361, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a364, 4); mov(dx, memw[ds, eax + 0x10]);          /* mov dx, [eax+0x10] */
            ii(0x100c_a368, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a36b, 4); mov(memw[ds, eax + 0x10], dx);          /* mov [eax+0x10], dx */
            ii(0x100c_a36f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a372, 4); mov(dx, memw[ds, eax + 0x12]);          /* mov dx, [eax+0x12] */
            ii(0x100c_a376, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a379, 4); mov(memw[ds, eax + 0x12], dx);          /* mov [eax+0x12], dx */
            ii(0x100c_a37d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a380, 4); mov(dx, memw[ds, eax + 0x14]);          /* mov dx, [eax+0x14] */
            ii(0x100c_a384, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a387, 4); mov(memw[ds, eax + 0x14], dx);          /* mov [eax+0x14], dx */
            ii(0x100c_a38b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a38e, 3); mov(al, memb[ds, eax + 0x16]);          /* mov al, [eax+0x16] */
            ii(0x100c_a391, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a394, 3); mov(memb[ds, edx + 0x16], al);          /* mov [edx+0x16], al */
            ii(0x100c_a397, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a39a, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x100c_a39e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3a1, 4); mov(memw[ds, edx + 0x17], ax);          /* mov [edx+0x17], ax */
            ii(0x100c_a3a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a3a8, 4); mov(ax, memw[ds, eax + 0x19]);          /* mov ax, [eax+0x19] */
            ii(0x100c_a3ac, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3af, 4); mov(memw[ds, edx + 0x19], ax);          /* mov [edx+0x19], ax */
            ii(0x100c_a3b3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a3b6, 4); mov(ax, memw[ds, eax + 0x1b]);          /* mov ax, [eax+0x1b] */
            ii(0x100c_a3ba, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3bd, 4); mov(memw[ds, edx + 0x1b], ax);          /* mov [edx+0x1b], ax */
            ii(0x100c_a3c1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a3c4, 4); mov(ax, memw[ds, eax + 0x1d]);          /* mov ax, [eax+0x1d] */
            ii(0x100c_a3c8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3cb, 4); mov(memw[ds, edx + 0x1d], ax);          /* mov [edx+0x1d], ax */
            ii(0x100c_a3cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a3d2, 4); mov(ax, memw[ds, eax + 0x1f]);          /* mov ax, [eax+0x1f] */
            ii(0x100c_a3d6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3d9, 4); mov(memw[ds, edx + 0x1f], ax);          /* mov [edx+0x1f], ax */
            ii(0x100c_a3dd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a3e0, 4); mov(ax, memw[ds, eax + 0x21]);          /* mov ax, [eax+0x21] */
            ii(0x100c_a3e4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3e7, 4); mov(memw[ds, edx + 0x21], ax);          /* mov [edx+0x21], ax */
            ii(0x100c_a3eb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a3ee, 3); mov(al, memb[ds, eax + 0x23]);          /* mov al, [eax+0x23] */
            ii(0x100c_a3f1, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_a3f4, 3); mov(memb[ds, edx + 0x23], al);          /* mov [edx+0x23], al */
            ii(0x100c_a3f7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a3fa, 7); mov(memd[ds, eax + 0x2], 0x101b_5780);  /* mov dword [eax+0x2], 0x101b5780 */
            ii(0x100c_a401, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a404, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_a407, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_a40a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a40c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a40d, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a40e, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a40f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a410, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a411, 1); ret();                                  /* ret */
        }
    }
}
