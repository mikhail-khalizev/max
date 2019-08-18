using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9324-56e1bb25")]
        public void Method_1008_9324()
        {
            ii(0x1008_9324, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9329, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ca24); /* call 0x10165d52 */
            ii(0x1008_932e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_932f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9330, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9331, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9332, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9333, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9335, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_933b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_933e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9341, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_9348, 2); if(jzd(0x1008_935e, 0x14)) goto l_0x1008_935e; /* jz 0x1008935e */
            ii(0x1008_934a, 5); mov(edx, 0x101b_3a2c);                  /* mov edx, 0x101b3a2c */
            ii(0x1008_934f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9352, 5); calld(Definitions.sys_call_dtor_arr, 0xd_cc61); /* call 0x10165fb8 */
            ii(0x1008_9357, 5); calld(Definitions.sys_delete_arr, 0xd_cc7c); /* call 0x10165fd8 */
            ii(0x1008_935c, 2); jmpd(0x1008_9392, 0x34); goto l_0x1008_9392; /* jmp 0x10089392 */
        l_0x1008_935e:
            ii(0x1008_935e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9360, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9363, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_9366, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x72f); /* call 0x10088c3c */
            ii(0x1008_936b, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_936e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9371, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_9376, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9379, 5); calld(0x100a_284c, 0x1_94ce);           /* call 0x100a284c */
            ii(0x1008_937e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9381, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_9388, 2); if(jzd(0x1008_9392, 0x8)) goto l_0x1008_9392; /* jz 0x10089392 */
            ii(0x1008_938a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_938d, 5); calld(Definitions.sys_delete, 0xd_cbd2); /* call 0x10165f64 */
        l_0x1008_9392:
            ii(0x1008_9392, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9395, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9398, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_939b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_939d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_939e, 1); popd(edi);                              /* pop edi */
            ii(0x1008_939f, 1); popd(esi);                              /* pop esi */
            ii(0x1008_93a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_93a1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_93a2, 1); retd(); return;                         /* ret */
        }
    }
}
