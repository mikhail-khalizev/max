using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6a34-d30e9e67")]
        public void /* sys */ Method_1016_6a34()
        {
            ii(0x1016_6a34, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_6a35, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_6a36, 1);  push(edx);                            /* push edx */
            ii(0x1016_6a37, 5);  call(/* sys */ 0x1016_7dac, 0x1370);  /* call 0x10167dac */
            ii(0x1016_6a3c, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1016_6a3e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_6a40, 2);  if(jz(0x1016_6a7a, 0x38)) goto l_0x1016_6a7a;/* jz 0x10166a7a */
            ii(0x1016_6a42, 3);  mov(edx, memd[ds, eax + 44]);         /* mov edx, [eax+0x2c] */
            ii(0x1016_6a45, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_6a47, 2);  if(jz(0x1016_6a50, 7)) goto l_0x1016_6a50;/* jz 0x10166a50 */
            ii(0x1016_6a49, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_6a4b, 5);  call(Definitions.sys_free_internal, 0x1_ba04);/* call 0x10182454 */
        l_0x1016_6a50:
            ii(0x1016_6a50, 3);  mov(ecx, memd[ds, ebx + 60]);         /* mov ecx, [ebx+0x3c] */
            ii(0x1016_6a53, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1016_6a55, 2);  if(jz(0x1016_6a5e, 7)) goto l_0x1016_6a5e;/* jz 0x10166a5e */
            ii(0x1016_6a57, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1016_6a59, 5);  call(Definitions.sys_free_internal, 0x1_b9f6);/* call 0x10182454 */
        l_0x1016_6a5e:
            ii(0x1016_6a5e, 3);  mov(eax, memd[ds, ebx + 48]);         /* mov eax, [ebx+0x30] */
            ii(0x1016_6a61, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_6a63, 2);  if(jz(0x1016_6a73, 0xe)) goto l_0x1016_6a73;/* jz 0x10166a73 */
        l_0x1016_6a65:
            ii(0x1016_6a65, 3);  mov(edx, memd[ds, eax + 112]);        /* mov edx, [eax+0x70] */
            ii(0x1016_6a68, 5);  call(/* sys */ 0x1016_9714, 0x2ca7);  /* call 0x10169714 */
            ii(0x1016_6a6d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_6a6f, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_6a71, 2);  if(jnz(0x1016_6a65, -0xe)) goto l_0x1016_6a65;/* jnz 0x10166a65 */
        l_0x1016_6a73:
            ii(0x1016_6a73, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1016_6a75, 5);  call(Definitions.sys_free_internal, 0x1_b9da);/* call 0x10182454 */
        l_0x1016_6a7a:
            ii(0x1016_6a7a, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_6a7b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_6a7c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_6a7d, 1);  ret();                                /* ret */
        }
    }
}
