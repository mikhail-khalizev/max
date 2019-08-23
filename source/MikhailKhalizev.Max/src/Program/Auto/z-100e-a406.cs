using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a406-3d707919")]
        public void Method_100e_a406()
        {
            ii(0x100e_a406, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_a40b, 5); call(Definitions.sys_check_available_stack_size, 0x7_b942); /* call 0x10165d52 */
            ii(0x100e_a410, 1); push(ebx);                              /* push ebx */
            ii(0x100e_a411, 1); push(ecx);                              /* push ecx */
            ii(0x100e_a412, 1); push(edx);                              /* push edx */
            ii(0x100e_a413, 1); push(esi);                              /* push esi */
            ii(0x100e_a414, 1); push(edi);                              /* push edi */
            ii(0x100e_a415, 1); push(ebp);                              /* push ebp */
            ii(0x100e_a416, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a418, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_a41e, 5); call(/* sys */ 0x1016_cc1c, 0x8_27f9);  /* call 0x1016cc1c */
            ii(0x100e_a423, 5); mov(memd[ds, 0x101c_3660], eax);        /* mov [0x101c3660], eax */
            ii(0x100e_a428, 5); mov(ebx, 0x8000);                       /* mov ebx, 0x8000 */
            ii(0x100e_a42d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_a42f, 5); mov(eax, 0x1020_0520);                  /* mov eax, 0x10200520 */
            ii(0x100e_a434, 5); call(Definitions.sys_memset, 0x7_b9a7); /* call 0x10165de0 */
            ii(0x100e_a439, 7); mov(memd[ss, ebp - 0x4], 0x1);          /* mov dword [ebp-0x4], 0x1 */
            ii(0x100e_a440, 2); jmp(0x100e_a448, 0x6); goto l_0x100e_a448; /* jmp 0x100ea448 */
        l_0x100e_a442:
            ii(0x100e_a442, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a445, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
        l_0x100e_a448:
            ii(0x100e_a448, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a44c, 5); cmp(eax, 0x100);                        /* cmp eax, 0x100 */
            ii(0x100e_a451, 2); if(jge(0x100e_a482, 0x2f)) goto l_0x100e_a482; /* jge 0x100ea482 */
            ii(0x100e_a453, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a456, 4); mov(memw[ss, ebp - 0xc], ax);           /* mov [ebp-0xc], ax */
            ii(0x100e_a45a, 3); lea(edx, memd[ss, ebp - 0xa]);          /* lea edx, [ebp-0xa] */
            ii(0x100e_a45d, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a461, 5); call(0x100e_9f69, -0x4fd);              /* call 0x100e9f69 */
            ii(0x100e_a466, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_a46b, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_a46e, 5); call(0x100e_a2d6, -0x19d);              /* call 0x100ea2d6 */
            ii(0x100e_a473, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x100e_a478, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_a47b, 5); call(0x100e_a2d6, -0x1aa);              /* call 0x100ea2d6 */
            ii(0x100e_a480, 2); jmp(0x100e_a442, -0x40); goto l_0x100e_a442; /* jmp 0x100ea442 */
        l_0x100e_a482:
            ii(0x100e_a482, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a484, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_a485, 1); pop(edi);                               /* pop edi */
            ii(0x100e_a486, 1); pop(esi);                               /* pop esi */
            ii(0x100e_a487, 1); pop(edx);                               /* pop edx */
            ii(0x100e_a488, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_a489, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_a48a, 1); ret();                                  /* ret */
        }
    }
}
