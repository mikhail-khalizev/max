using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a2b8-c367fca0")]
        public void Method_100a_a2b8()
        {
            ii(0x100a_a2b8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a2bd, 5); call(Definitions.sys_check_available_stack_size, 0xb_ba90); /* call 0x10165d52 */
            ii(0x100a_a2c2, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a2c3, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a2c4, 1); push(esi);                              /* push esi */
            ii(0x100a_a2c5, 1); push(edi);                              /* push edi */
            ii(0x100a_a2c6, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a2c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a2c9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a2cf, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a2d2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a2d5, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a2dc, 2); if(jz(0x100a_a2f2, 0x14)) goto l_0x100a_a2f2; /* jz 0x100aa2f2 */
            ii(0x100a_a2de, 5); mov(edx, 0x101b_4c7c);                  /* mov edx, 0x101b4c7c */
            ii(0x100a_a2e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a2e6, 5); call(Definitions.sys_call_dtor_arr, 0xb_bccd); /* call 0x10165fb8 */
            ii(0x100a_a2eb, 5); call(Definitions.sys_delete_arr, 0xb_bce8); /* call 0x10165fd8 */
            ii(0x100a_a2f0, 2); jmp(0x100a_a326, 0x34); goto l_0x100a_a326; /* jmp 0x100aa326 */
        l_0x100a_a2f2:
            ii(0x100a_a2f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a2f4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a2f7, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_a2fa, 5); call(0x1007_5f2c, -0x3_43d3);           /* call 0x10075f2c */
            ii(0x100a_a2ff, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x100a_a302, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a305, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_a30a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a30d, 5); call(0x100a_36c9, -0x6c49);             /* call 0x100a36c9 */
            ii(0x100a_a312, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a315, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a31c, 2); if(jz(0x100a_a326, 8)) goto l_0x100a_a326; /* jz 0x100aa326 */
            ii(0x100a_a31e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a321, 5); call(Definitions.sys_delete, 0xb_bc3e); /* call 0x10165f64 */
        l_0x100a_a326:
            ii(0x100a_a326, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a329, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a32c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a32f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a331, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a332, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a333, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a334, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a335, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a336, 1); ret();                                  /* ret */
        }
    }
}
