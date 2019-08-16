using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7cfb8515-58ad-4375-b8ae-e858b29e3a54")]
        public void Method_1008_93a4()
        {
            ii(0x1008_93a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_93a9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c9a4); /* call 0x10165d52 */
            ii(0x1008_93ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_93af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_93b0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_93b1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_93b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_93b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_93b5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_93bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_93be, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_93c1, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_93c8, 2); if(jzd(0x1008_93de, 0x14)) goto l_0x1008_93de; /* jz 0x100893de */
            ii(0x1008_93ca, 5); mov(edx, 0x101b_3a40);                  /* mov edx, 0x101b3a40 */
            ii(0x1008_93cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_93d2, 5); calld(Definitions.sys_call_dtor_arr, 0xd_cbe1); /* call 0x10165fb8 */
            ii(0x1008_93d7, 5); calld(Definitions.sys_delete_arr, 0xd_cbfc); /* call 0x10165fd8 */
            ii(0x1008_93dc, 2); jmpd(0x1008_9412, 0x34); goto l_0x1008_9412; /* jmp 0x10089412 */
        l_0x1008_93de:
            ii(0x1008_93de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_93e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_93e3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_93e6, 5); calld(Definitions.my_dtor_0x101b_56fc, -0x7af); /* call 0x10088c3c */
            ii(0x1008_93eb, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_93ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_93f1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_93f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_93f9, 5); calld(0x100a_284c, 0x1_944e);           /* call 0x100a284c */
            ii(0x1008_93fe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9401, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_9408, 2); if(jzd(0x1008_9412, 0x8)) goto l_0x1008_9412; /* jz 0x10089412 */
            ii(0x1008_940a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_940d, 5); calld(Definitions.sys_delete, 0xd_cb52); /* call 0x10165f64 */
        l_0x1008_9412:
            ii(0x1008_9412, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9415, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9418, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_941b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_941d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_941e, 1); popd(edi);                              /* pop edi */
            ii(0x1008_941f, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9420, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9421, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9422, 1); retd(); return;                         /* ret */
        }
    }
}