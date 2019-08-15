using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1fbfc182-4d31-4111-8487-2c7a083fa571")]
        public void Method_1014_6516()
        {
            ii(0x1014_6516, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_651b, 5); calld(Definitions.sys_check_available_stack_size, 0x1_f832); /* call 0x10165d52 */
            ii(0x1014_6520, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_6521, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_6522, 1); pushd(edx);                             /* push edx */
            ii(0x1014_6523, 1); pushd(esi);                             /* push esi */
            ii(0x1014_6524, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6525, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6526, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6528, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_652e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1014_6531:
            ii(0x1014_6531, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6534, 5); calld(0x1014_6462, -0xd7);              /* call 0x10146462 */
            ii(0x1014_6539, 2); test(al, al);                           /* test al, al */
            ii(0x1014_653b, 2); if(jzd(0x1014_6559, 0x1c)) goto l_0x1014_6559; /* jz 0x10146559 */
            ii(0x1014_653d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_6540, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_6543, 5); calld(0x1014_7f14, 0x19cc);             /* call 0x10147f14 */
            ii(0x1014_6548, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_654b, 3); add(ebx, 0x1c);                         /* add ebx, 0x1c */
            ii(0x1014_654e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6550, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_6552, 5); calld(0x1014_7e70, 0x1919);             /* call 0x10147e70 */
            ii(0x1014_6557, 2); jmpd(0x1014_6531, -0x28); goto l_0x1014_6531; /* jmp 0x10146531 */
        l_0x1014_6559:
            ii(0x1014_6559, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_655b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_655c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_655d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_655e, 1); popd(edx);                              /* pop edx */
            ii(0x1014_655f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_6560, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_6561, 1); retd(); return;                         /* ret */
        }
    }
}
