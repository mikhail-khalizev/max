using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_0a29-c99a9693")]
        public void Method_1007_0a29()
        {
            ii(0x1007_0a29, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_0a2e, 5);  call(Definitions.sys_check_available_stack_size, 0xf_531f);/* call 0x10165d52 */
            ii(0x1007_0a33, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_0a34, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_0a35, 1);  push(edx);                            /* push edx */
            ii(0x1007_0a36, 1);  push(esi);                            /* push esi */
            ii(0x1007_0a37, 1);  push(edi);                            /* push edi */
            ii(0x1007_0a38, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_0a39, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_0a3b, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_0a41, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1007_0a46, 5);  call(0x1007_09c4, -0x87);             /* call 0x100709c4 */
            ii(0x1007_0a4b, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x1007_0a50, 5);  call(0x1007_09c4, -0x91);             /* call 0x100709c4 */
            ii(0x1007_0a55, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1007_0a5a, 5);  call(0x1007_09c4, -0x9b);             /* call 0x100709c4 */
            ii(0x1007_0a5f, 5);  mov(eax, 0x101c_8190);                /* mov eax, 0x101c8190 */
            ii(0x1007_0a64, 5);  call(0x1007_09c4, -0xa5);             /* call 0x100709c4 */
            ii(0x1007_0a69, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1007_0a6e, 5);  call(0x1007_09c4, -0xaf);             /* call 0x100709c4 */
            ii(0x1007_0a73, 6);  mov(edx, memd[ds, 0x101c_8170]);      /* mov edx, [0x101c8170] */
            ii(0x1007_0a79, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_0a7c, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1007_0a81, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_0a84, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_0a87, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_0a8a, 7);  mov(memd[ss, ebp - 4], 4);            /* mov dword [ebp-0x4], 0x4 */
        l_0x1007_0a91:
            ii(0x1007_0a91, 3);  dec(memd[ss, ebp - 4]);               /* dec dword [ebp-0x4] */
            ii(0x1007_0a94, 5);  cmp(memw[ss, ebp - 4], -1 /* 0xff */);/* cmp word [ebp-0x4], 0xffff */
            ii(0x1007_0a99, 2);  if(jz(0x1007_0b08, 0x6d)) goto l_0x1007_0b08;/* jz 0x10070b08 */
            ii(0x1007_0a9b, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0a9f, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_0aa5, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_0aab, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_0ab0, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_0ab2, 2);  if(jz(0x1007_0b06, 0x52)) goto l_0x1007_0b06;/* jz 0x10070b06 */
            ii(0x1007_0ab4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_0ab7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_0ab9, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_0abd, 6);  imul(ebx, ebx, 0x247);                /* imul ebx, ebx, 0x247 */
            ii(0x1007_0ac3, 6);  mov(ecx, memd[ds, ebx + 0x101c_a6a3]);/* mov ecx, [ebx+0x101ca6a3] */
            ii(0x1007_0ac9, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1007_0acb, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1007_0acd, 5);  call(Definitions.sys_memset, 0xf_530e);/* call 0x10165de0 */
            ii(0x1007_0ad2, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_0ad5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_0ad7, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0adb, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_0ae1, 6);  mov(eax, memd[ds, eax + 0x101c_a6a7]);/* mov eax, [eax+0x101ca6a7] */
            ii(0x1007_0ae7, 5);  call(Definitions.sys_memset, 0xf_52f4);/* call 0x10165de0 */
            ii(0x1007_0aec, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_0aef, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_0af1, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0af5, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_0afb, 6);  mov(eax, memd[ds, eax + 0x101c_a6ab]);/* mov eax, [eax+0x101ca6ab] */
            ii(0x1007_0b01, 5);  call(Definitions.sys_memset, 0xf_52da);/* call 0x10165de0 */
        l_0x1007_0b06:
            ii(0x1007_0b06, 2);  jmp(0x1007_0a91, -0x77); goto l_0x1007_0a91;/* jmp 0x10070a91 */
        l_0x1007_0b08:
            ii(0x1007_0b08, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_0b0a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_0b0b, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_0b0c, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_0b0d, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_0b0e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_0b0f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_0b10, 1);  ret();                                /* ret */
        }
    }
}
