using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ddbe02a8-25a2-4dc1-96f5-9bb58409647d")]
        public void /* sys */ Method_1016_a68c()
        {
            ii(0x1016_a68c, 1); pushd(esi);                             /* push esi */
            ii(0x1016_a68d, 1); pushd(edi);                             /* push edi */
            ii(0x1016_a68e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_a68f, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_a692, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_a694, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_a696, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1016_a699, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
            ii(0x1016_a69b, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_a69f, 1); pushd(edx);                             /* push edx */
            ii(0x1016_a6a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a6a1, 4); mov(ebx, memd_a32[ss, esp + 0x1c]);     /* mov ebx, [esp+0x1c] */
            ii(0x1016_a6a5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_a6a6, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_a6a8, 4); mov(ebx, memd_a32[ss, esp + 0xc]);      /* mov ebx, [esp+0xc] */
            ii(0x1016_a6ac, 5); calld(/* sys */ 0x1016_a5a0, -0x111);   /* call 0x1016a5a0 */
            ii(0x1016_a6b1, 4); mov(ecx, memd_a32[ss, esp + 0x1c]);     /* mov ecx, [esp+0x1c] */
            ii(0x1016_a6b5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a6b6, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1016_a6ba, 4); mov(edx, memd_a32[ss, esp + 0x18]);     /* mov edx, [esp+0x18] */
            ii(0x1016_a6be, 1); pushd(eax);                             /* push eax */
            ii(0x1016_a6bf, 4); mov(ebx, memd_a32[ss, esp + 0x8]);      /* mov ebx, [esp+0x8] */
            ii(0x1016_a6c3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_a6c5, 1); pushd(edx);                             /* push edx */
            ii(0x1016_a6c6, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a6c8, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_a6ca, 5); calld(/* sys */ 0x1016_a5a0, -0x12f);   /* call 0x1016a5a0 */
            ii(0x1016_a6cf, 4); mov(ebx, memd_a32[ss, esp + 0x1c]);     /* mov ebx, [esp+0x1c] */
            ii(0x1016_a6d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_a6d4, 4); mov(ecx, memd_a32[ss, esp + 0x1c]);     /* mov ecx, [esp+0x1c] */
            ii(0x1016_a6d8, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1016_a6dc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a6dd, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_a6df, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_a6e1, 1); pushd(eax);                             /* push eax */
            ii(0x1016_a6e2, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1016_a6e4, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a6e6, 5); calld(/* sys */ 0x1016_a5a0, -0x14b);   /* call 0x1016a5a0 */
            ii(0x1016_a6eb, 4); mov(edx, memd_a32[ss, esp + 0x1c]);     /* mov edx, [esp+0x1c] */
            ii(0x1016_a6ef, 1); pushd(edx);                             /* push edx */
            ii(0x1016_a6f0, 4); mov(ebx, memd_a32[ss, esp + 0x1c]);     /* mov ebx, [esp+0x1c] */
            ii(0x1016_a6f4, 4); mov(ecx, memd_a32[ss, esp + 0x18]);     /* mov ecx, [esp+0x18] */
            ii(0x1016_a6f8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_a6f9, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a6fb, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_a6fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_a6fe, 4); mov(ebx, memd_a32[ss, esp + 0x20]);     /* mov ebx, [esp+0x20] */
            ii(0x1016_a702, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1016_a704, 5); calld(/* sys */ 0x1016_a5a0, -0x169);   /* call 0x1016a5a0 */
            ii(0x1016_a709, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_a70c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_a70d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_a70e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_a70f, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
