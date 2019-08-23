using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5fe0-8f9cff35")]
        public void /* sys */ sys_call_dtor_arr_v2()
        {
            ii(0x1016_5fe0, 1); push(ecx);                              /* push ecx */
            ii(0x1016_5fe1, 1); push(esi);                              /* push esi */
            ii(0x1016_5fe2, 3); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1016_5fe5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_5fe7, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_5fe9, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_5feb, 5); call(/* sys */ 0x1018_1cf1, 0x1_bd01);  /* call 0x10181cf1 */
            ii(0x1016_5ff0, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_5ff2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_5ff4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_5ff6, 4); mov(memd[ss, esp + 0x8], esi);          /* mov [esp+0x8], esi */
            ii(0x1016_5ffa, 5); call(/* sys */ 0x1018_1ee8, 0x1_bee9);  /* call 0x10181ee8 */
            ii(0x1016_5fff, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_6001, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1016_6003, 2); mov(memd[ds, ebx], eax);                /* mov [ebx], eax */
            ii(0x1016_6005, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_6007, 3); add(esp, 0x20);                         /* add esp, 0x20 */
            ii(0x1016_600a, 1); pop(esi);                               /* pop esi */
            ii(0x1016_600b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_600c, 1); ret();                                  /* ret */
        }
    }
}
