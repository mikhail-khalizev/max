using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f8e6b73a-aff2-41c0-9270-fb336794972d")]
        public void /* sys */ sys_strcat()
        {
            ii(0x1016_5f31, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5f32, 1); pushd(esi);                             /* push esi */
            ii(0x1016_5f33, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5f34, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_5f36, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_5f38, 1); pushd(es);                              /* push es */
            ii(0x1016_5f39, 1); pushd(ds);                              /* push ds */
            ii(0x1016_5f3a, 1); popd(es);                               /* pop es */
            ii(0x1016_5f3b, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5f3c, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1016_5f3e, 1); dec(ecx);                               /* dec ecx */
            ii(0x1016_5f3f, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1016_5f41, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1016_5f43, 1); dec(edi);                               /* dec edi */
        l_0x1016_5f44:
            ii(0x1016_5f44, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1016_5f46, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1016_5f48, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1016_5f4a, 2); if(jzd(0x1016_5f5c, 0x10)) goto l_0x1016_5f5c; /* jz 0x10165f5c */
            ii(0x1016_5f4c, 3); mov(al, memb_a32[ds, esi + 0x1]);       /* mov al, [esi+0x1] */
            ii(0x1016_5f4f, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1016_5f52, 3); mov(memb_a32[ds, edi + 0x1], al);       /* mov [edi+0x1], al */
            ii(0x1016_5f55, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1016_5f58, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1016_5f5a, 2); if(jnzd(0x1016_5f44, -0x18)) goto l_0x1016_5f44; /* jnz 0x10165f44 */
        l_0x1016_5f5c:
            ii(0x1016_5f5c, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5f5d, 1); popd(es);                               /* pop es */
            ii(0x1016_5f5e, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_5f60, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5f61, 1); popd(esi);                              /* pop esi */
            ii(0x1016_5f62, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5f63, 1); retd(); return;                         /* ret */
        }
    }
}
