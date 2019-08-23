using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4465-aac0de98")]
        public void Method_1014_4465()
        {
            ii(0x1014_4465, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_446a, 5); calld(Definitions.sys_check_available_stack_size, 0x2_18e3); /* call 0x10165d52 */
            ii(0x1014_446f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4470, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4471, 1); pushd(edx);                             /* push edx */
            ii(0x1014_4472, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4473, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4474, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4475, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4477, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_447d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_4480, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_4487, 2); jmpd(0x1014_448f, 0x6); goto l_0x1014_448f; /* jmp 0x1014448f */
        l_0x1014_4489:
            ii(0x1014_4489, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_448c, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1014_448f:
            ii(0x1014_448f, 4); cmp(memd_a32[ss, ebp - 0x8], 0xb);      /* cmp dword [ebp-0x8], 0xb */
            ii(0x1014_4493, 2); if(jged(0x1014_44c7, 0x32)) goto l_0x1014_44c7; /* jge 0x101444c7 */
            ii(0x1014_4495, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_4498, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1014_449b, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1014_449e, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x1014_44a1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_44a4, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1014_44a8, 2); if(jzd(0x1014_44be, 0x14)) goto l_0x1014_44be; /* jz 0x101444be */
            ii(0x1014_44aa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_44ac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_44af, 5); calld(Definitions.my_dtor_d2, -0x7_5f7c); /* call 0x100ce538 */
            ii(0x1014_44b4, 5); calld(Definitions.sys_delete, 0x2_1aab); /* call 0x10165f64 */
            ii(0x1014_44b9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_44bc, 2); jmpd(0x1014_44c5, 0x7); goto l_0x1014_44c5; /* jmp 0x101444c5 */
        l_0x1014_44be:
            ii(0x1014_44be, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1014_44c5:
            ii(0x1014_44c5, 2); jmpd(0x1014_4489, -0x3e); goto l_0x1014_4489; /* jmp 0x10144489 */
        l_0x1014_44c7:
            ii(0x1014_44c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_44ca, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1014_44cd, 5); calld(/* sys */ 0x1016_6990, 0x2_24be); /* call 0x10166990 */
            ii(0x1014_44d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_44d5, 3); mov(eax, memd_a32[ds, eax + 0x1e]);     /* mov eax, [eax+0x1e] */
            ii(0x1014_44d8, 5); calld(Definitions.sys_free, 0x2_6be4);  /* call 0x1016b0c1 */
            ii(0x1014_44dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_44df, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_44e0, 1); popd(edi);                              /* pop edi */
            ii(0x1014_44e1, 1); popd(esi);                              /* pop esi */
            ii(0x1014_44e2, 1); popd(edx);                              /* pop edx */
            ii(0x1014_44e3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_44e4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_44e5, 1); retd();                                 /* ret */
        }
    }
}
