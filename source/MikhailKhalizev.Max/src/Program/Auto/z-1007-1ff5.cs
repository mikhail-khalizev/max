using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c620528d-a4d5-4274-81d1-f6b04b993a81")]
        public void Method_1007_1ff5()
        {
            ii(0x1007_1ff5, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_1ffa, 5); calld(Definitions.sys_check_available_stack_size, 0xf3d53); /* call 0x10165d52 */
            ii(0x1007_1fff, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_2000, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_2001, 1); pushd(edx);                             /* push edx */
            ii(0x1007_2002, 1); pushd(esi);                             /* push esi */
            ii(0x1007_2003, 1); pushd(edi);                             /* push edi */
            ii(0x1007_2004, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_2005, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_2007, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_200d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_2010, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_2013, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_2016, 2); jmpd(0x1007_2040, 0x28); goto l_0x1007_2040; /* jmp 0x10072040 */
        //  ii(0x1007_2018, 18); Недостижимый код.
l_0x1007_202a:
            ii(0x1007_202a, 2); jmpd(0x1007_2060, 0x34); goto l_0x1007_2060; /* jmp 0x10072060 */
        //  ii(0x1007_202c, 20); Недостижимый код.
l_0x1007_2040:
            ii(0x1007_2040, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_2043, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x1007_2046, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_2049, 5); cmp(memw_a32[ss, ebp - 0x10], 0x4);     /* cmp word [ebp-0x10], 0x4 */
            ii(0x1007_204e, 2); if(jad(0x1007_202a, -0x26)) goto l_0x1007_202a; /* ja 0x1007202a */
            ii(0x1007_2050, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_2052, 4); mov(ax, memw_a32[ss, ebp - 0x10]);      /* mov ax, [ebp-0x10] */
            ii(0x1007_2056, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2059, 7); jmpd_abs(memd_a32[cs, eax + 0x1007_202c]); return; /* jmp dword [cs:eax+0x1007202c] */
        l_0x1007_2060:
            ii(0x1007_2060, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_2067, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_206a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_206c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_206d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_206e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_206f, 1); popd(edx);                              /* pop edx */
            ii(0x1007_2070, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_2071, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_2072, 1); retd(); return;                         /* ret */
        }
    }
}
