using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("169fc7df-c613-423d-b3d6-b62516e1a13f")]
        public void Method_100c_08dc()
        {
            ii(0x100c_08dc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_08e1, 5); calld(Definitions.sys_check_available_stack_size, 0xa546c); /* call 0x10165d52 */
            ii(0x100c_08e6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_08e7, 1); pushd(esi);                             /* push esi */
            ii(0x100c_08e8, 1); pushd(edi);                             /* push edi */
            ii(0x100c_08e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_08ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_08ec, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_08f2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_08f5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_08f8, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100c_08fb, 5); mov(ecx, 0x101c_8184);                  /* mov ecx, 0x101c8184 */
            ii(0x100c_0900, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_0903, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_0906, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100c_090a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_090d, 5); calld(0x100c_0837, -0xdb);              /* call 0x100c0837 */
            ii(0x100c_0912, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100c_0914, 5); mov(ecx, 0x101c_81a8);                  /* mov ecx, 0x101c81a8 */
            ii(0x100c_0919, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_091c, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_091f, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100c_0923, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_0926, 5); calld(0x100c_0837, -0xf4);              /* call 0x100c0837 */
            ii(0x100c_092b, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x100c_092d, 3); mov(memd_a32[ss, ebp - 0x10], esi);     /* mov [ebp-0x10], esi */
            ii(0x100c_0930, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_0933, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_0935, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_0936, 1); popd(edi);                              /* pop edi */
            ii(0x100c_0937, 1); popd(esi);                              /* pop esi */
            ii(0x100c_0938, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_0939, 1); retd(); return;                         /* ret */
        }
    }
}
