using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1694a6a9-5344-42d6-a9e6-3aa68880c802")]
        public void Method_1012_4174()
        {
            ii(0x1012_4174, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_4179, 5); calld(Definitions.sys_check_available_stack_size, 0x4_1bd4); /* call 0x10165d52 */
            ii(0x1012_417e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_417f, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4180, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4181, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4182, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4184, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_418a, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_418d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_418e, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4191, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4192, 5); calld(0x1012_3850, -0x947);             /* call 0x10123850 */
            ii(0x1012_4197, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1012_419a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_419c, 2); if(jnzd(0x1012_41a7, 0x9)) goto l_0x1012_41a7; /* jnz 0x101241a7 */
            ii(0x1012_419e, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_41a5, 2); jmpd(0x1012_41cf, 0x28); goto l_0x1012_41cf; /* jmp 0x101241cf */
        l_0x1012_41a7:
            ii(0x1012_41a7, 3); mov(eax, memd_a32[ss, ebp + 0x20]);     /* mov eax, [ebp+0x20] */
            ii(0x1012_41aa, 1); pushd(eax);                             /* push eax */
            ii(0x1012_41ab, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1012_41ae, 1); pushd(eax);                             /* push eax */
            ii(0x1012_41af, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_41b2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_41b3, 5); calld(0x1012_3b6c, -0x64c);             /* call 0x10123b6c */
            ii(0x1012_41b8, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_41bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_41bd, 2); if(jnzd(0x1012_41c8, 0x9)) goto l_0x1012_41c8; /* jnz 0x101241c8 */
            ii(0x1012_41bf, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_41c6, 2); jmpd(0x1012_41cf, 0x7); goto l_0x1012_41cf; /* jmp 0x101241cf */
        l_0x1012_41c8:
            ii(0x1012_41c8, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_41cf:
            ii(0x1012_41cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_41d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_41d4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_41d5, 1); popd(edi);                              /* pop edi */
            ii(0x1012_41d6, 1); popd(esi);                              /* pop esi */
            ii(0x1012_41d7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_41d8, 1); retd(); return;                         /* ret */
        }
    }
}
