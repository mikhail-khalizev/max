using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b310-4aab9fd3")]
        public void /* sys */ Method_1016_b310()
        {
            ii(0x1016_b310, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b311, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b312, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b313, 1); pushd(esi);                             /* push esi */
            ii(0x1016_b314, 6); mov(edx, memd_a32[ds, 0x101c_fb6c]);    /* mov edx, [0x101cfb6c] */
            ii(0x1016_b31a, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_b31f, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1016_b321, 2); if(jzd(0x1016_b369, 0x46)) goto l_0x1016_b369; /* jz 0x1016b369 */
            ii(0x1016_b323, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1016_b32a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_b32c, 1); inc(edx);                               /* inc edx */
            ii(0x1016_b32d, 7); mov(ebx, memd_a32[ds, eax * 4 + 0x101c_f96c]); /* mov ebx, [eax*4+0x101cf96c] */
            ii(0x1016_b334, 7); mov(ecx, memd_a32[ds, eax * 4 + 0x101c_f970]); /* mov ecx, [eax*4+0x101cf970] */
            ii(0x1016_b33b, 7); mov(eax, memd_a32[ds, eax * 4 + 0x101c_f974]); /* mov eax, [eax*4+0x101cf974] */
            ii(0x1016_b342, 6); mov(memd_a32[ds, 0x101c_fb4c], ecx);    /* mov [0x101cfb4c], ecx */
            ii(0x1016_b348, 5); mov(memd_a32[ds, 0x101c_fb50], eax);    /* mov [0x101cfb50], eax */
            ii(0x1016_b34d, 3); cmp(edx, 0x28);                         /* cmp edx, 0x28 */
            ii(0x1016_b350, 2); if(jnzd(0x1016_b354, 0x2)) goto l_0x1016_b354; /* jnz 0x1016b354 */
            ii(0x1016_b352, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_b354:
            ii(0x1016_b354, 6); cmp(edx, memd_a32[ds, 0x101c_fb78]);    /* cmp edx, [0x101cfb78] */
            ii(0x1016_b35a, 2); if(jnzd(0x1016_b369, 0xd)) goto l_0x1016_b369; /* jnz 0x1016b369 */
            ii(0x1016_b35c, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_b35e, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1016_b363, 6); mov(memd_a32[ds, 0x101c_fb78], esi);    /* mov [0x101cfb78], esi */
        l_0x1016_b369:
            ii(0x1016_b369, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_b36b, 6); mov(memd_a32[ds, 0x101c_fb6c], edx);    /* mov [0x101cfb6c], edx */
            ii(0x1016_b371, 1); popd(esi);                              /* pop esi */
            ii(0x1016_b372, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b373, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b374, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b375, 1); retd(); return;                         /* ret */
        }
    }
}
