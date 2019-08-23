using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_be34-35a5555f")]
        public void /* sys */ Method_1016_be34()
        {
            ii(0x1016_be34, 1); push(ecx);                              /* push ecx */
            ii(0x1016_be35, 1); push(esi);                              /* push esi */
            ii(0x1016_be36, 1); push(edi);                              /* push edi */
            ii(0x1016_be37, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_be3a, 7); cmp(memd[ds, 0x101c_fbe8], 0);          /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_be41, 2); if(jz(0x1016_be92, 0x4f)) goto l_0x1016_be92; /* jz 0x1016be92 */
            ii(0x1016_be43, 7); cmp(memd[ds, 0x101c_fb90], 0);          /* cmp dword [0x101cfb90], 0x0 */
            ii(0x1016_be4a, 2); if(jnz(0x1016_be92, 0x46)) goto l_0x1016_be92; /* jnz 0x1016be92 */
            ii(0x1016_be4c, 5); mov(eax, memd[ds, 0x101c_fbd4]);        /* mov eax, [0x101cfbd4] */
            ii(0x1016_be51, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_be54, 5); mov(eax, memd[ds, 0x101c_fbd0]);        /* mov eax, [0x101cfbd0] */
            ii(0x1016_be59, 6); mov(esi, memd[ds, 0x101c_fbf0]);        /* mov esi, [0x101cfbf0] */
            ii(0x1016_be5f, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1016_be63, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_be66, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_be6b, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_be6d, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_be6f, 6); mov(edi, memd[ds, 0x101c_fb94]);        /* mov edi, [0x101cfb94] */
            ii(0x1016_be75, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1016_be79, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1016_be7d, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_be7f, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_be81, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1016_be85, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_be87, 6); mov(memd[ds, 0x101c_fb90], ecx);        /* mov [0x101cfb90], ecx */
            ii(0x1016_be8d, 5); call(/* sys */ 0x1016_7ac0, -0x43d2);   /* call 0x10167ac0 */
        l_0x1016_be92:
            ii(0x1016_be92, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_be95, 1); pop(edi);                               /* pop edi */
            ii(0x1016_be96, 1); pop(esi);                               /* pop esi */
            ii(0x1016_be97, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_be98, 1); ret();                                  /* ret */
        }
    }
}
