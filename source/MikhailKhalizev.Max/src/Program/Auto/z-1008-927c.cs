using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_927c-c4056597")]
        public void Method_1008_927c()
        {
            ii(0x1008_927c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9281, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cacc); /* call 0x10165d52 */
            ii(0x1008_9286, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9287, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9288, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9289, 1); pushd(edi);                             /* push edi */
            ii(0x1008_928a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_928b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_928d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9293, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9296, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9299, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_92a0, 2); if(jzd(0x1008_92b6, 0x14)) goto l_0x1008_92b6; /* jz 0x100892b6 */
            ii(0x1008_92a2, 5); mov(edx, 0x101b_3a18);                  /* mov edx, 0x101b3a18 */
            ii(0x1008_92a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_92aa, 5); calld(Definitions.sys_call_dtor_arr, 0xd_cd09); /* call 0x10165fb8 */
            ii(0x1008_92af, 5); calld(Definitions.sys_delete_arr, 0xd_cd24); /* call 0x10165fd8 */
            ii(0x1008_92b4, 2); jmpd(0x1008_9310, 0x5a); goto l_0x1008_9310; /* jmp 0x10089310 */
        l_0x1008_92b6:
            ii(0x1008_92b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_92b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_92bb, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1008_92be, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x687); /* call 0x10088c3c */
            ii(0x1008_92c3, 3); sub(eax, 0x22);                         /* sub eax, 0x22 */
            ii(0x1008_92c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_92c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_92cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_92ce, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1008_92d1, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x69a); /* call 0x10088c3c */
            ii(0x1008_92d6, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1008_92d9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_92dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_92de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_92e1, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1008_92e4, 5); calld(0x1008_8e0c, -0x4dd);             /* call 0x10088e0c */
            ii(0x1008_92e9, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1008_92ec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_92ef, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_92f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_92f7, 5); calld(0x100a_284c, 0x1_9550);           /* call 0x100a284c */
            ii(0x1008_92fc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_92ff, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_9306, 2); if(jzd(0x1008_9310, 0x8)) goto l_0x1008_9310; /* jz 0x10089310 */
            ii(0x1008_9308, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_930b, 5); calld(Definitions.sys_delete, 0xd_cc54); /* call 0x10165f64 */
        l_0x1008_9310:
            ii(0x1008_9310, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9313, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9316, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9319, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_931b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_931c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_931d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_931e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_931f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9320, 1); retd(); return;                         /* ret */
        }
    }
}
