using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a494-28ab0254")]
        public void Method_100c_a494()
        {
            ii(0x100c_a494, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a499, 5); call(Definitions.sys_check_available_stack_size, 0x9_b8b4); /* call 0x10165d52 */
            ii(0x100c_a49e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a49f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a4a0, 1); push(esi);                              /* push esi */
            ii(0x100c_a4a1, 1); push(edi);                              /* push edi */
            ii(0x100c_a4a2, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a4a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a4a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a4ab, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a4ae, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a4b1, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_a4b8, 2); if(jz(0x100c_a4ce, 0x14)) goto l_0x100c_a4ce; /* jz 0x100ca4ce */
            ii(0x100c_a4ba, 5); mov(edx, 0x101b_565c);                  /* mov edx, 0x101b565c */
            ii(0x100c_a4bf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a4c2, 5); call(Definitions.sys_call_dtor_arr, 0x9_baf1); /* call 0x10165fb8 */
            ii(0x100c_a4c7, 5); call(Definitions.sys_delete_arr, 0x9_bb0c); /* call 0x10165fd8 */
            ii(0x100c_a4cc, 2); jmp(0x100c_a502, 0x34); goto l_0x100c_a502; /* jmp 0x100ca502 */
        l_0x100c_a4ce:
            ii(0x100c_a4ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_a4d0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a4d3, 3); add(eax, 9);                            /* add eax, 0x9 */
            ii(0x100c_a4d6, 5); call(0x100a_9f38, -0x2_05a3);           /* call 0x100a9f38 */
            ii(0x100c_a4db, 3); sub(eax, 9);                            /* sub eax, 0x9 */
            ii(0x100c_a4de, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a4e1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100c_a4e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a4e9, 5); call(0x1013_ab27, 0x7_0639);            /* call 0x1013ab27 */
            ii(0x100c_a4ee, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a4f1, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_a4f8, 2); if(jz(0x100c_a502, 8)) goto l_0x100c_a502; /* jz 0x100ca502 */
            ii(0x100c_a4fa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a4fd, 5); call(Definitions.sys_delete, 0x9_ba62); /* call 0x10165f64 */
        l_0x100c_a502:
            ii(0x100c_a502, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a505, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a508, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_a50b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a50d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a50e, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a50f, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a510, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a511, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a512, 1); ret();                                  /* ret */
        }
    }
}
