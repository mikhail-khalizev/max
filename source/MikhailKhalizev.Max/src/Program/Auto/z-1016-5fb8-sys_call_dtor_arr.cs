using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5fb8-3108f326")]
        public void /* sys */ sys_call_dtor_arr()
        {
            ii(0x1016_5fb8, 1); push(ebx);                              /* push ebx */
            ii(0x1016_5fb9, 1); push(ecx);                              /* push ecx */
            ii(0x1016_5fba, 1); push(esi);                              /* push esi */
            ii(0x1016_5fbb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5fbd, 2); if(jnz(0x1016_5fc3, 0x4)) goto l_0x1016_5fc3; /* jnz 0x10165fc3 */
            ii(0x1016_5fbf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_5fc1, 2); jmp(0x1016_5fd1, 0xe); goto l_0x1016_5fd1; /* jmp 0x10165fd1 */
        l_0x1016_5fc3:
            ii(0x1016_5fc3, 3); lea(ecx, memd[ds, eax - 0x4]);          /* lea ecx, [eax-0x4] */
            ii(0x1016_5fc6, 2); mov(esi, memd[ds, ecx]);                /* mov esi, [ecx] */
            ii(0x1016_5fc8, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_5fca, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_5fcc, 5); call(Definitions.sys_call_dtor_arr_v2, 0xf); /* call 0x10165fe0 */
        l_0x1016_5fd1:
            ii(0x1016_5fd1, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_5fd3, 1); pop(esi);                               /* pop esi */
            ii(0x1016_5fd4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_5fd5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_5fd6, 1); ret();                                  /* ret */
        }
    }
}
