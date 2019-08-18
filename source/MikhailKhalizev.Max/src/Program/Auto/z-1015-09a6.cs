using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_09a6-5d83bab9")]
        public void Method_1015_09a6()
        {
            ii(0x1015_09a6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_09ab, 5); calld(Definitions.sys_check_available_stack_size, 0x1_53a2); /* call 0x10165d52 */
            ii(0x1015_09b0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_09b1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_09b2, 1); pushd(edx);                             /* push edx */
            ii(0x1015_09b3, 1); pushd(esi);                             /* push esi */
            ii(0x1015_09b4, 1); pushd(edi);                             /* push edi */
            ii(0x1015_09b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_09b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_09b8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_09be, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_09c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_09c4, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1015_09c8, 2); if(jzd(0x1015_09ef, 0x25)) goto l_0x1015_09ef; /* jz 0x101509ef */
            ii(0x1015_09ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_09cd, 5); calld(0x1007_623c, -0xd_a796);          /* call 0x1007623c */
            ii(0x1015_09d2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_09d4, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_09d9, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1015_09de, 5); calld(0x1007_1e00, -0xd_ebe3);          /* call 0x10071e00 */
            ii(0x1015_09e3, 4); mov(dx, memw_a32[ds, ebx + 0x8]);       /* mov dx, [ebx+0x8] */
            ii(0x1015_09e7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_09ea, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1015_09ed, 2); jmpd(0x1015_0a53, 0x64); goto l_0x1015_0a53; /* jmp 0x10150a53 */
        l_0x1015_09ef:
            ii(0x1015_09ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_09f2, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_09f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_09f8, 3); cmp(eax, 0x42);                         /* cmp eax, 0x42 */
            ii(0x1015_09fb, 2); if(jzd(0x1015_0a0b, 0xe)) goto l_0x1015_0a0b; /* jz 0x10150a0b */
            ii(0x1015_09fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0a00, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_0a03, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0a06, 3); cmp(eax, 0x43);                         /* cmp eax, 0x43 */
            ii(0x1015_0a09, 2); if(jnzd(0x1015_0a30, 0x25)) goto l_0x1015_0a30; /* jnz 0x10150a30 */
        l_0x1015_0a0b:
            ii(0x1015_0a0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0a0e, 5); calld(0x1007_623c, -0xd_a7d7);          /* call 0x1007623c */
            ii(0x1015_0a13, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_0a15, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_0a1a, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1015_0a1f, 5); calld(0x1007_1e00, -0xd_ec24);          /* call 0x10071e00 */
            ii(0x1015_0a24, 4); mov(dx, memw_a32[ds, ebx + 0x8]);       /* mov dx, [ebx+0x8] */
            ii(0x1015_0a28, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_0a2b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1015_0a2e, 2); jmpd(0x1015_0a53, 0x23); goto l_0x1015_0a53; /* jmp 0x10150a53 */
        l_0x1015_0a30:
            ii(0x1015_0a30, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0a33, 5); calld(0x1007_623c, -0xd_a7fc);          /* call 0x1007623c */
            ii(0x1015_0a38, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_0a3a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_0a3f, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1015_0a44, 5); calld(0x1007_1e00, -0xd_ec49);          /* call 0x10071e00 */
            ii(0x1015_0a49, 4); mov(dx, memw_a32[ds, ebx + 0x8]);       /* mov dx, [ebx+0x8] */
            ii(0x1015_0a4d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_0a50, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
        l_0x1015_0a53:
            ii(0x1015_0a53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_0a56, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0a58, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_0a59, 1); popd(edi);                              /* pop edi */
            ii(0x1015_0a5a, 1); popd(esi);                              /* pop esi */
            ii(0x1015_0a5b, 1); popd(edx);                              /* pop edx */
            ii(0x1015_0a5c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_0a5d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_0a5e, 1); retd(); return;                         /* ret */
        }
    }
}
