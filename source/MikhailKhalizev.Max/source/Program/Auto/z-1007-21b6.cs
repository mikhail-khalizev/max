using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_21b6-948a9933")]
        public void Method_1007_21b6()
        {
            ii(0x1007_21b6, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_21bb, 5);  call(Definitions.sys_check_available_stack_size, 0xf_3b92);/* call 0x10165d52 */
            ii(0x1007_21c0, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_21c1, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_21c2, 1);  push(esi);                            /* push esi */
            ii(0x1007_21c3, 1);  push(edi);                            /* push edi */
            ii(0x1007_21c4, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_21c5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_21c7, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1007_21cd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_21d0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_21d3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_21d6, 5);  call(0x1007_20e6, -0xf5);             /* call 0x100720e6 */
            ii(0x1007_21db, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_21de, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_21e1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_21e4, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1007_21e7, 6);  mov(al, memb[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1007_21ed, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1007_21f0, 2);  jmp(0x1007_2223, 0x31); goto l_0x1007_2223;/* jmp 0x10072223 */
        l_0x1007_21f2:
            ii(0x1007_21f2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_21f5, 4);  mov(dx, memw[ds, eax + 82]);          /* mov dx, [eax+0x52] */
            ii(0x1007_21f9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_21fc, 4);  add(memw[ds, eax + 2], dx);           /* add [eax+0x2], dx */
            ii(0x1007_2200, 2);  jmp(0x1007_2245, 0x43); goto l_0x1007_2245;/* jmp 0x10072245 */
        l_0x1007_2202:
            ii(0x1007_2202, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_2205, 4);  mov(dx, memw[ds, eax + 82]);          /* mov dx, [eax+0x52] */
            ii(0x1007_2209, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_220c, 4);  add(memw[ds, eax + 4], dx);           /* add [eax+0x4], dx */
            ii(0x1007_2210, 2);  jmp(0x1007_2245, 0x33); goto l_0x1007_2245;/* jmp 0x10072245 */
        l_0x1007_2212:
            ii(0x1007_2212, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_2215, 4);  mov(dx, memw[ds, eax + 82]);          /* mov dx, [eax+0x52] */
            ii(0x1007_2219, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_221c, 3);  add(memw[ds, eax], dx);               /* add [eax], dx */
            ii(0x1007_221f, 2);  jmp(0x1007_2245, 0x24); goto l_0x1007_2245;/* jmp 0x10072245 */
        l_0x1007_2221:
            ii(0x1007_2221, 2);  jmp(0x1007_2245, 0x22); goto l_0x1007_2245;/* jmp 0x10072245 */
        l_0x1007_2223:
            ii(0x1007_2223, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_2226, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1007_2229, 4);  cmp(memb[ss, ebp - 20], 2);           /* cmp byte [ebp-0x14], 0x2 */
            ii(0x1007_222d, 2);  if(jb(0x1007_223d, 0xe)) goto l_0x1007_223d;/* jb 0x1007223d */
            ii(0x1007_222f, 4);  cmp(memb[ss, ebp - 20], 2);           /* cmp byte [ebp-0x14], 0x2 */
            ii(0x1007_2233, 2);  if(jbe(0x1007_2202, -0x33)) goto l_0x1007_2202;/* jbe 0x10072202 */
            ii(0x1007_2235, 4);  cmp(memb[ss, ebp - 20], 3);           /* cmp byte [ebp-0x14], 0x3 */
            ii(0x1007_2239, 2);  if(jz(0x1007_2212, -0x29)) goto l_0x1007_2212;/* jz 0x10072212 */
            ii(0x1007_223b, 2);  jmp(0x1007_2221, -0x1c); goto l_0x1007_2221;/* jmp 0x10072221 */
        l_0x1007_223d:
            ii(0x1007_223d, 4);  cmp(memb[ss, ebp - 20], 1);           /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1007_2241, 2);  if(jz(0x1007_21f2, -0x51)) goto l_0x1007_21f2;/* jz 0x100721f2 */
            ii(0x1007_2243, 2);  jmp(0x1007_2221, -0x24); goto l_0x1007_2221;/* jmp 0x10072221 */
        l_0x1007_2245:
            ii(0x1007_2245, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2248, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_224b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_224e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2250, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2251, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2252, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2253, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2254, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_2255, 1);  ret();                                /* ret */
        }
    }
}
