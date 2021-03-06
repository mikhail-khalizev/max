using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_10bd-76f4ecb8")]
        public void Method_1011_10bd()
        {
            ii(0x1011_10bd, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_10c2, 5);  call(Definitions.sys_check_available_stack_size, 0x5_4c8b);/* call 0x10165d52 */
            ii(0x1011_10c7, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_10c8, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_10c9, 1);  push(edx);                            /* push edx */
            ii(0x1011_10ca, 1);  push(esi);                            /* push esi */
            ii(0x1011_10cb, 1);  push(edi);                            /* push edi */
            ii(0x1011_10cc, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_10cd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_10cf, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1011_10d5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_10d8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_10db, 4);  cmp(memd[ds, eax + 12], 0xe);         /* cmp dword [eax+0xc], 0xe */
            ii(0x1011_10df, 6);  if(jnz(0x1011_1159, 0x74)) goto l_0x1011_1159;/* jnz 0x10111159 */
            ii(0x1011_10e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_10e8, 6);  mov(eax, memd[ds, eax + 328]);        /* mov eax, [eax+0x148] */
            ii(0x1011_10ee, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_10f1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_10f3, 2);  if(jz(0x1011_1154, 0x5f)) goto l_0x1011_1154;/* jz 0x10111154 */
            ii(0x1011_10f5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_10f8, 7);  mov(ax, memw[ds, eax + 330]);         /* mov ax, [eax+0x14a] */
            ii(0x1011_10ff, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_1102, 7);  sub(ax, memw[ds, edx + 332]);         /* sub ax, [edx+0x14c] */
            ii(0x1011_1109, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_110c, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_1110, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_1112, 2);  if(jge(0x1011_111b, 7)) goto l_0x1011_111b;/* jge 0x1011111b */
            ii(0x1011_1114, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1011_111b:
            ii(0x1011_111b, 5);  call(0x1014_82f4, 0x3_71d4);          /* call 0x101482f4 */
            ii(0x1011_1120, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_1123, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1126, 7);  dec(memw[ds, eax + 330]);             /* dec word [eax+0x14a] */
            ii(0x1011_112d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1130, 5);  call(0x1011_0357, -0xdde);            /* call 0x10110357 */
        l_0x1011_1135:
            ii(0x1011_1135, 5);  call(0x1014_82f4, 0x3_71ba);          /* call 0x101482f4 */
            ii(0x1011_113a, 3);  sub(eax, memd[ss, ebp - 12]);         /* sub eax, [ebp-0xc] */
            ii(0x1011_113d, 5);  cmp(eax, 0x308c);                     /* cmp eax, 0x308c */
            ii(0x1011_1142, 2);  if(jb(0x1011_1135, -0xf)) goto l_0x1011_1135;/* jb 0x10111135 */
            ii(0x1011_1144, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1147, 7);  mov(ax, memw[ds, eax + 330]);         /* mov ax, [eax+0x14a] */
            ii(0x1011_114e, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1011_1152, 2);  if(jnz(0x1011_111b, -0x39)) goto l_0x1011_111b;/* jnz 0x1011111b */
        l_0x1011_1154:
            ii(0x1011_1154, 5);  jmp(0x1011_11d3, 0x7a); goto l_0x1011_11d3;/* jmp 0x101111d3 */
        l_0x1011_1159:
            ii(0x1011_1159, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_115c, 6);  mov(edx, memd[ds, eax + 328]);        /* mov edx, [eax+0x148] */
            ii(0x1011_1162, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_1165, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1168, 6);  mov(eax, memd[ds, eax + 330]);        /* mov eax, [eax+0x14a] */
            ii(0x1011_116e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_1171, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_1173, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1176, 6);  mov(eax, memd[ds, eax + 326]);        /* mov eax, [eax+0x146] */
            ii(0x1011_117c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_117f, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1011_1181, 2);  if(jge(0x1011_11d3, 0x50)) goto l_0x1011_11d3;/* jge 0x101111d3 */
            ii(0x1011_1183, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1186, 7);  mov(ax, memw[ds, eax + 330]);         /* mov ax, [eax+0x14a] */
            ii(0x1011_118d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_1190, 7);  add(ax, memw[ds, edx + 332]);         /* add ax, [edx+0x14c] */
            ii(0x1011_1197, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x1011_119a:
            ii(0x1011_119a, 5);  call(0x1014_82f4, 0x3_7155);          /* call 0x101482f4 */
            ii(0x1011_119f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_11a2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_11a5, 7);  inc(memw[ds, eax + 330]);             /* inc word [eax+0x14a] */
            ii(0x1011_11ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_11af, 5);  call(0x1011_0357, -0xe5d);            /* call 0x10110357 */
        l_0x1011_11b4:
            ii(0x1011_11b4, 5);  call(0x1014_82f4, 0x3_713b);          /* call 0x101482f4 */
            ii(0x1011_11b9, 3);  sub(eax, memd[ss, ebp - 20]);         /* sub eax, [ebp-0x14] */
            ii(0x1011_11bc, 5);  cmp(eax, 0x308c);                     /* cmp eax, 0x308c */
            ii(0x1011_11c1, 2);  if(jb(0x1011_11b4, -0xf)) goto l_0x1011_11b4;/* jb 0x101111b4 */
            ii(0x1011_11c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_11c6, 7);  mov(ax, memw[ds, eax + 330]);         /* mov ax, [eax+0x14a] */
            ii(0x1011_11cd, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1011_11d1, 2);  if(jnz(0x1011_119a, -0x39)) goto l_0x1011_119a;/* jnz 0x1011119a */
        l_0x1011_11d3:
            ii(0x1011_11d3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_11d5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_11d6, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_11d7, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_11d8, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_11d9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_11da, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_11db, 1);  ret();                                /* ret */
        }
    }
}
