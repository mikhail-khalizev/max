using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("21c9cdb5-ce5f-4e22-a777-9fb20322c958")]
        public void Method_1007_0d01()
        {
            ii(0x1007_0d01, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_0d06, 5); calld(Definitions.sys_check_available_stack_size, 0xf5047); /* call 0x10165d52 */
            ii(0x1007_0d0b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_0d0c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_0d0d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_0d0e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_0d0f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_0d10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_0d12, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_0d18, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_0d1b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_0d1e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_0d21, 5); calld(Definitions.my_ctor_0x101b4184, 0x5dca); /* call 0x10076af0 */
            ii(0x1007_0d26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0d29, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1007_0d2d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_0d30, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x1007_0d34, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x1007_0d38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_0d3b, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1007_0d3f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_0d42, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x1007_0d46, 4); mov(memw_a32[ss, ebp - 0xe], ax);       /* mov [ebp-0xe], ax */
            ii(0x1007_0d4a, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x1007_0d4d, 4); imul(eax, memd_a32[ss, ebp - 0xe]);     /* imul eax, [ebp-0xe] */
            ii(0x1007_0d51, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1007_0d54, 4); imul(edx, memd_a32[ss, ebp - 0x10]);    /* imul edx, [ebp-0x10] */
            ii(0x1007_0d58, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_0d5a, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1007_0d5d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_0d60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0d62, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_0d63, 1); popd(edi);                              /* pop edi */
            ii(0x1007_0d64, 1); popd(esi);                              /* pop esi */
            ii(0x1007_0d65, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_0d66, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_0d67, 1); retd(); return;                         /* ret */
        }
    }
}