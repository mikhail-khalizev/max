using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4954-c9dd1fe5")]
        public void Method_100a_4954()
        {
            ii(0x100a_4954, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_4959, 5); call(Definitions.sys_check_available_stack_size, 0xc_13f4); /* call 0x10165d52 */
            ii(0x100a_495e, 1); push(esi);                              /* push esi */
            ii(0x100a_495f, 1); push(edi);                              /* push edi */
            ii(0x100a_4960, 1); push(ebp);                              /* push ebp */
            ii(0x100a_4961, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_4963, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_4969, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_496c, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_496f, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100a_4972, 3); mov(memd[ss, ebp - 12], ecx);           /* mov [ebp-0xc], ecx */
            ii(0x100a_4975, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x100a_4978, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_497b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_497e, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_4981, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_4984, 3); call_abs(memd[ds, edx + 20]);           /* call dword [edx+0x14] */
            ii(0x100a_4987, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_498a, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100a_498e, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_4992, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_4995, 5); call(0x100a_4583, -0x417);              /* call 0x100a4583 */
            ii(0x100a_499a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_499c, 2); if(jz(0x100a_49c8, 0x2a)) goto l_0x100a_49c8; /* jz 0x100a49c8 */
            ii(0x100a_499e, 3); mov(ecx, memd[ss, ebp + 16]);           /* mov ecx, [ebp+0x10] */
            ii(0x100a_49a1, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100a_49a4, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100a_49a7, 5); call(0x1007_5e64, -0x2_eb48);           /* call 0x10075e64 */
            ii(0x100a_49ac, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_49ae, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100a_49b2, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100a_49b6, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x100a_49bc, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100a_49c1, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100a_49c3, 5); call(0x100b_e5c2, 0x1_9bfa);            /* call 0x100be5c2 */
        l_0x100a_49c8:
            ii(0x100a_49c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_49ca, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_49cb, 1); pop(edi);                               /* pop edi */
            ii(0x100a_49cc, 1); pop(esi);                               /* pop esi */
            ii(0x100a_49cd, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
