using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5f70-a9570af3")]
        public void /* sys */ sys_call_ctor_arr_v2()
        {
            ii(0x1016_5f70, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_5f71, 1);  push(esi);                            /* push esi */
            ii(0x1016_5f72, 1);  push(edi);                            /* push edi */
            ii(0x1016_5f73, 3);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1016_5f76, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1016_5f78, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1016_5f7a, 2);  mov(edi, ebx);                        /* mov edi, ebx */
            ii(0x1016_5f7c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_5f7e, 2);  if(jz(0x1016_5fb1, 0x31)) goto l_0x1016_5fb1;/* jz 0x10165fb1 */
            ii(0x1016_5f80, 2);  mov(edx, esp);                        /* mov edx, esp */
            ii(0x1016_5f82, 5);  call(/* sys */ 0x1018_1cf1, 0x1_bd6a);/* call 0x10181cf1 */
            ii(0x1016_5f87, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1016_5f89, 3);  mov(eax, memd[ds, edi + 1]);          /* mov eax, [edi+0x1] */
            ii(0x1016_5f8c, 3);  mov(edx, memd[ds, edi + 13]);         /* mov edx, [edi+0xd] */
            ii(0x1016_5f8f, 4);  mov(memd[ss, esp + 32], eax);         /* mov [esp+0x20], eax */
        l_0x1016_5f93:
            ii(0x1016_5f93, 4);  cmp(esi, memd[ss, esp + 8]);          /* cmp esi, [esp+0x8] */
            ii(0x1016_5f97, 2);  if(jbe(0x1016_5fa7, 0xe)) goto l_0x1016_5fa7;/* jbe 0x10165fa7 */
            ii(0x1016_5f99, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1016_5f9b, 4);  call_abs(memd[ss, esp + 32]);         /* call dword [esp+0x20] */
            ii(0x1016_5f9f, 4);  inc(memd[ss, esp + 8]);               /* inc dword [esp+0x8] */
            ii(0x1016_5fa3, 2);  add(ecx, edx);                        /* add ecx, edx */
            ii(0x1016_5fa5, 2);  jmp(0x1016_5f93, -0x14); goto l_0x1016_5f93;/* jmp 0x10165f93 */
        l_0x1016_5fa7:
            ii(0x1016_5fa7, 2);  mov(eax, memd[ds, ebx]);              /* mov eax, [ebx] */
            ii(0x1016_5fa9, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1016_5fab, 2);  mov(memd[ds, ebx], eax);              /* mov [ebx], eax */
            ii(0x1016_5fad, 4);  mov(eax, memd[ss, esp + 12]);         /* mov eax, [esp+0xc] */
        l_0x1016_5fb1:
            ii(0x1016_5fb1, 3);  add(esp, 0x24);                       /* add esp, 0x24 */
            ii(0x1016_5fb4, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_5fb5, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_5fb6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_5fb7, 1);  ret();                                /* ret */
        }
    }
}
