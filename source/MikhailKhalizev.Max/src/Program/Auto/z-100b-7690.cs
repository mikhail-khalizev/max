using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7690-53df4b04")]
        public void Method_100b_7690()
        {
            ii(0x100b_7690, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7695, 5); call(Definitions.sys_check_available_stack_size, 0xa_e6b8); /* call 0x10165d52 */
            ii(0x100b_769a, 1); push(ebx);                              /* push ebx */
            ii(0x100b_769b, 1); push(ecx);                              /* push ecx */
            ii(0x100b_769c, 1); push(esi);                              /* push esi */
            ii(0x100b_769d, 1); push(edi);                              /* push edi */
            ii(0x100b_769e, 1); push(ebp);                              /* push ebp */
            ii(0x100b_769f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_76a1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_76a7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_76aa, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_76ad, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_76b4, 2); if(jz(0x100b_76ca, 0x14)) goto l_0x100b_76ca; /* jz 0x100b76ca */
            ii(0x100b_76b6, 5); mov(edx, 0x101b_50bc);                  /* mov edx, 0x101b50bc */
            ii(0x100b_76bb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_76be, 5); call(Definitions.sys_call_dtor_arr, 0xa_e8f5); /* call 0x10165fb8 */
            ii(0x100b_76c3, 5); call(Definitions.sys_delete_arr, 0xa_e910); /* call 0x10165fd8 */
            ii(0x100b_76c8, 2); jmp(0x100b_7711, 0x47); goto l_0x100b_7711; /* jmp 0x100b7711 */
        l_0x100b_76ca:
            ii(0x100b_76ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_76cc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_76cf, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_76d2, 5); call(0x1007_5f2c, -0x4_17ab);           /* call 0x10075f2c */
            ii(0x100b_76d7, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100b_76da, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_76dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_76df, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_76e2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_76e5, 5); call(0x1008_8d4c, -0x2_e99e);           /* call 0x10088d4c */
            ii(0x100b_76ea, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_76ed, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_76f0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_76f5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_76f8, 5); call(0x100a_284c, -0x1_4eb1);           /* call 0x100a284c */
            ii(0x100b_76fd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7700, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_7707, 2); if(jz(0x100b_7711, 0x8)) goto l_0x100b_7711; /* jz 0x100b7711 */
            ii(0x100b_7709, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_770c, 5); call(Definitions.sys_delete, 0xa_e853); /* call 0x10165f64 */
        l_0x100b_7711:
            ii(0x100b_7711, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7714, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_7717, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_771a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_771c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_771d, 1); pop(edi);                               /* pop edi */
            ii(0x100b_771e, 1); pop(esi);                               /* pop esi */
            ii(0x100b_771f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7720, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7721, 1); ret();                                  /* ret */
        }
    }
}
