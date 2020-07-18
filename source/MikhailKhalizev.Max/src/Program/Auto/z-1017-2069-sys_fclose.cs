using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2069-e0c5d53c")]
        public void /* sys */ sys_fclose()
        {
            ii(0x1017_2069, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_206a, 1);  push(edx);                            /* push edx */
            ii(0x1017_206b, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_206d, 5);  mov(eax, memd[ds, 0x1020_b70c]);      /* mov eax, [0x1020b70c] */
        l_0x1017_2072:
            ii(0x1017_2072, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_2074, 2);  if(jnz(0x1017_207e, 8)) goto l_0x1017_207e;/* jnz 0x1017207e */
            ii(0x1017_2076, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1017_207b, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_207c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_207d, 1);  ret(); return;                        /* ret */
        l_0x1017_207e:
            ii(0x1017_207e, 3);  cmp(ebx, memd[ds, eax + 4]);          /* cmp ebx, [eax+0x4] */
            ii(0x1017_2081, 2);  if(jz(0x1017_2087, 4)) goto l_0x1017_2087;/* jz 0x10172087 */
            ii(0x1017_2083, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1017_2085, 2);  jmp(0x1017_2072, -0x15); goto l_0x1017_2072;/* jmp 0x10172072 */
        l_0x1017_2087:
            ii(0x1017_2087, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1017_208c, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_208e, 5);  call(/* sys */ 0x1017_2096, 3);       /* call 0x10172096 */
            ii(0x1017_2093, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_2094, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_2095, 1);  ret();                                /* ret */
        }
    }
}
