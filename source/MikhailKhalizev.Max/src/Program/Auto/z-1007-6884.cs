using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5414a807-6260-4ae5-931f-7b2312d8f7d2")]
        public void Method_1007_6884()
        {
            ii(0x1007_6884, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6889, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f4c4); /* call 0x10165d52 */
            ii(0x1007_688e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_688f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6890, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6891, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6892, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6893, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6894, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6896, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_689c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_689f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_68a2, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1007_68a5, 2); if(jzd(0x1007_68b0, 0x9)) goto l_0x1007_68b0; /* jz 0x100768b0 */
            ii(0x1007_68a7, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_68ae, 2); jmpd(0x1007_68c9, 0x19); goto l_0x1007_68c9; /* jmp 0x100768c9 */
        l_0x1007_68b0:
            ii(0x1007_68b0, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1007_68b5, 5); mov(ebx, StringDefinitions.SmartptrH3); /* mov ebx, 0x101a0018 */
            ii(0x1007_68ba, 5); mov(edx, StringDefinitions.PtrNotEqual03); /* mov edx, 0x101a0023 */
            ii(0x1007_68bf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_68c1, 5); calld(Definitions.sys_assert, 0xe_f4cc); /* call 0x10165d92 */
            ii(0x1007_68c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1007_68c9:
            ii(0x1007_68c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_68cc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_68ce, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_68d1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_68d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_68d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_68d7, 1); popd(edi);                              /* pop edi */
            ii(0x1007_68d8, 1); popd(esi);                              /* pop esi */
            ii(0x1007_68d9, 1); popd(edx);                              /* pop edx */
            ii(0x1007_68da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_68db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_68dc, 1); retd(); return;                         /* ret */
        }
    }
}
