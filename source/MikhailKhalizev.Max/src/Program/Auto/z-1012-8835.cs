using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc44b6b8-274a-47d5-a497-3a4a33a2e508")]
        public void Method_1012_8835()
        {
            ii(0x1012_8835, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_883a, 5); calld(Definitions.sys_check_available_stack_size, 0x3d513); /* call 0x10165d52 */
            ii(0x1012_883f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_8840, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_8841, 1); pushd(edx);                             /* push edx */
            ii(0x1012_8842, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8843, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8844, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8845, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8847, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_884d, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1012_8850, 5); calld(0x1012_75ed, -0x1268);            /* call 0x101275ed */
            ii(0x1012_8855, 5); calld(0x1014_82f4, 0x1fa9a);            /* call 0x101482f4 */
            ii(0x1012_885a, 6); sub(eax, memd_a32[ds, 0x101c_3974]);    /* sub eax, [0x101c3974] */
            ii(0x1012_8860, 5); cmp(eax, 0xc233);                       /* cmp eax, 0xc233 */
            ii(0x1012_8865, 2); if(jaed(0x1012_8870, 0x9)) goto l_0x1012_8870; /* jae 0x10128870 */
            ii(0x1012_8867, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1012_886e, 2); jmpd(0x1012_888b, 0x1b); goto l_0x1012_888b; /* jmp 0x1012888b */
        l_0x1012_8870:
            ii(0x1012_8870, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_8872, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_8875, 5); calld(0x1012_869d, -0x1dd);             /* call 0x1012869d */
            ii(0x1012_887a, 5); calld(0x1014_82f4, 0x1fa75);            /* call 0x101482f4 */
            ii(0x1012_887f, 5); mov(memd_a32[ds, 0x101c_3974], eax);    /* mov [0x101c3974], eax */
            ii(0x1012_8884, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
        l_0x1012_888b:
            ii(0x1012_888b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_888e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8890, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_8891, 1); popd(edi);                              /* pop edi */
            ii(0x1012_8892, 1); popd(esi);                              /* pop esi */
            ii(0x1012_8893, 1); popd(edx);                              /* pop edx */
            ii(0x1012_8894, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8895, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8896, 1); retd(); return;                         /* ret */
        }
    }
}