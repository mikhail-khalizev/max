using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_73a8-2c4881e7")]
        public void Method_100b_73a8()
        {
            ii(0x100b_73a8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_73ad, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e9a0); /* call 0x10165d52 */
            ii(0x100b_73b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_73b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_73b4, 1); pushd(esi);                             /* push esi */
            ii(0x100b_73b5, 1); pushd(edi);                             /* push edi */
            ii(0x100b_73b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_73b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_73b9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_73bf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_73c2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_73c5, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_73cc, 2); if(jzd(0x100b_73e2, 0x14)) goto l_0x100b_73e2; /* jz 0x100b73e2 */
            ii(0x100b_73ce, 5); mov(edx, 0x101b_506c);                  /* mov edx, 0x101b506c */
            ii(0x100b_73d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_73d6, 5); calld(Definitions.sys_call_dtor_arr, 0xa_ebdd); /* call 0x10165fb8 */
            ii(0x100b_73db, 5); calld(Definitions.sys_delete_arr, 0xa_ebf8); /* call 0x10165fd8 */
            ii(0x100b_73e0, 2); jmpd(0x100b_7416, 0x34); goto l_0x100b_7416; /* jmp 0x100b7416 */
        l_0x100b_73e2:
            ii(0x100b_73e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_73e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_73e7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_73ea, 5); calld(0x100b_7368, -0x87);              /* call 0x100b7368 */
            ii(0x100b_73ef, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_73f2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_73f5, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_73fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_73fd, 5); calld(0x100a_284c, -0x1_4bb6);          /* call 0x100a284c */
            ii(0x100b_7402, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7405, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_740c, 2); if(jzd(0x100b_7416, 0x8)) goto l_0x100b_7416; /* jz 0x100b7416 */
            ii(0x100b_740e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7411, 5); calld(Definitions.sys_delete, 0xa_eb4e); /* call 0x10165f64 */
        l_0x100b_7416:
            ii(0x100b_7416, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7419, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_741c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_741f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7421, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7422, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7423, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7424, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7425, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7426, 1); retd(); return;                         /* ret */
        }
    }
}
