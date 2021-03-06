using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f2a2-507cf302")]
        public void Method_1014_f2a2()
        {
            ii(0x1014_f2a2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_f2a7, 5);  call(Definitions.sys_check_available_stack_size, 0x1_6aa6);/* call 0x10165d52 */
            ii(0x1014_f2ac, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_f2ad, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_f2ae, 1);  push(esi);                            /* push esi */
            ii(0x1014_f2af, 1);  push(edi);                            /* push edi */
            ii(0x1014_f2b0, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_f2b1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_f2b3, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_f2b9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_f2bc, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f2bf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f2c2, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_f2c5, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_f2ca, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_f2ce, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1014_f2d0, 6);  if(jz(0x1014_f42a, 0x154)) goto l_0x1014_f42a;/* jz 0x1014f42a */
            ii(0x1014_f2d6, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f2da, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_f2dd, 7);  cmp(memb[ds, eax + 171], 0);          /* cmp byte [eax+0xab], 0x0 */
            ii(0x1014_f2e4, 2);  if(jnz(0x1014_f31f, 0x39)) goto l_0x1014_f31f;/* jnz 0x1014f31f */
            ii(0x1014_f2e6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f2e9, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f2ee, 2);  if(jz(0x1014_f2fa, 0xa)) goto l_0x1014_f2fa;/* jz 0x1014f2fa */
            ii(0x1014_f2f0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f2f3, 5);  cmp(memw[ds, eax + 8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1014_f2f8, 2);  if(jnz(0x1014_f2fc, 2)) goto l_0x1014_f2fc;/* jnz 0x1014f2fc */
        l_0x1014_f2fa:
            ii(0x1014_f2fa, 2);  jmp(0x1014_f306, 0xa); goto l_0x1014_f306;/* jmp 0x1014f306 */
        l_0x1014_f2fc:
            ii(0x1014_f2fc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f2ff, 5);  cmp(memw[ds, eax + 8], 0x41);         /* cmp word [eax+0x8], 0x41 */
            ii(0x1014_f304, 2);  if(jnz(0x1014_f308, 2)) goto l_0x1014_f308;/* jnz 0x1014f308 */
        l_0x1014_f306:
            ii(0x1014_f306, 2);  jmp(0x1014_f30d, 5); goto l_0x1014_f30d;/* jmp 0x1014f30d */
        l_0x1014_f308:
            ii(0x1014_f308, 5);  jmp(0x1014_f42a, 0x11d); goto l_0x1014_f42a;/* jmp 0x1014f42a */
        l_0x1014_f30d:
            ii(0x1014_f30d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f310, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x1014_f313, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_f316, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1014_f319, 6);  if(jl(0x1014_f42a, 0x10b)) goto l_0x1014_f42a;/* jl 0x1014f42a */
        l_0x1014_f31f:
            ii(0x1014_f31f, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f323, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_f326, 7);  mov(memb[ds, eax + 171], 0);          /* mov byte [eax+0xab], 0x0 */
            ii(0x1014_f32d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f330, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f335, 2);  if(jz(0x1014_f341, 0xa)) goto l_0x1014_f341;/* jz 0x1014f341 */
            ii(0x1014_f337, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f33a, 5);  cmp(memw[ds, eax + 8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1014_f33f, 2);  if(jnz(0x1014_f343, 2)) goto l_0x1014_f343;/* jnz 0x1014f343 */
        l_0x1014_f341:
            ii(0x1014_f341, 2);  jmp(0x1014_f351, 0xe); goto l_0x1014_f351;/* jmp 0x1014f351 */
        l_0x1014_f343:
            ii(0x1014_f343, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f346, 5);  cmp(memw[ds, eax + 8], 0x41);         /* cmp word [eax+0x8], 0x41 */
            ii(0x1014_f34b, 6);  if(jnz(0x1014_f422, 0xd1)) goto l_0x1014_f422;/* jnz 0x1014f422 */
        l_0x1014_f351:
            ii(0x1014_f351, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_f358, 2);  jmp(0x1014_f360, 6); goto l_0x1014_f360;/* jmp 0x1014f360 */
        l_0x1014_f35a:
            ii(0x1014_f35a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_f35d, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1014_f360:
            ii(0x1014_f360, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1014_f364, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1014_f367, 2);  if(jge(0x1014_f3ad, 0x44)) goto l_0x1014_f3ad;/* jge 0x1014f3ad */
            ii(0x1014_f369, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f36c, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_f36f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_f374, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1014_f378, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1014_f37a, 2);  if(jz(0x1014_f395, 0x19)) goto l_0x1014_f395;/* jz 0x1014f395 */
            ii(0x1014_f37c, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1014_f380, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1014_f386, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1014_f38c, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1014_f391, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1014_f393, 2);  if(jnz(0x1014_f397, 2)) goto l_0x1014_f397;/* jnz 0x1014f397 */
        l_0x1014_f395:
            ii(0x1014_f395, 2);  jmp(0x1014_f3a7, 0x10); goto l_0x1014_f3a7;/* jmp 0x1014f3a7 */
        l_0x1014_f397:
            ii(0x1014_f397, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1014_f39b, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_f39e, 7);  cmp(memb[ds, eax + 171], 0);          /* cmp byte [eax+0xab], 0x0 */
            ii(0x1014_f3a5, 2);  if(jnz(0x1014_f3a9, 2)) goto l_0x1014_f3a9;/* jnz 0x1014f3a9 */
        l_0x1014_f3a7:
            ii(0x1014_f3a7, 2);  jmp(0x1014_f3ab, 2); goto l_0x1014_f3ab;/* jmp 0x1014f3ab */
        l_0x1014_f3a9:
            ii(0x1014_f3a9, 2);  jmp(0x1014_f3ad, 2); goto l_0x1014_f3ad;/* jmp 0x1014f3ad */
        l_0x1014_f3ab:
            ii(0x1014_f3ab, 2);  jmp(0x1014_f35a, -0x53); goto l_0x1014_f35a;/* jmp 0x1014f35a */
        l_0x1014_f3ad:
            ii(0x1014_f3ad, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1014_f3b1, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1014_f3b4, 6);  if(jnz(0x1014_f422, 0x68)) goto l_0x1014_f422;/* jnz 0x1014f422 */
            ii(0x1014_f3ba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3bd, 5);  call(0x1016_433b, 0x1_4f79);          /* call 0x1016433b */
            ii(0x1014_f3c2, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_f3c4, 2);  if(jz(0x1014_f3ed, 0x27)) goto l_0x1014_f3ed;/* jz 0x1014f3ed */
            ii(0x1014_f3c6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3c9, 6);  mov(memw[ds, eax + 51], 0);           /* mov word [eax+0x33], 0x0 */
            ii(0x1014_f3cf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3d2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_f3d4, 3);  mov(dl, memb[ds, eax + 41]);          /* mov dl, [eax+0x29] */
            ii(0x1014_f3d7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3da, 4);  mov(ax, memw[ds, eax + 51]);          /* mov ax, [eax+0x33] */
            ii(0x1014_f3de, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1014_f3e0, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_f3e3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3e6, 5);  call(0x1014_9b07, -0x58e4);           /* call 0x10149b07 */
            ii(0x1014_f3eb, 2);  jmp(0x1014_f422, 0x35); goto l_0x1014_f422;/* jmp 0x1014f422 */
        l_0x1014_f3ed:
            ii(0x1014_f3ed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3f0, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_f3f5, 2);  if(jnz(0x1014_f400, 9)) goto l_0x1014_f400;/* jnz 0x1014f400 */
            ii(0x1014_f3f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f3fa, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1014_f3fe, 2);  if(jz(0x1014_f402, 2)) goto l_0x1014_f402;/* jz 0x1014f402 */
        l_0x1014_f400:
            ii(0x1014_f400, 2);  jmp(0x1014_f422, 0x20); goto l_0x1014_f422;/* jmp 0x1014f422 */
        l_0x1014_f402:
            ii(0x1014_f402, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f405, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x1014_f408, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_f40b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1014_f40d, 2);  if(jnz(0x1014_f422, 0x13)) goto l_0x1014_f422;/* jnz 0x1014f422 */
            ii(0x1014_f40f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f412, 3);  mov(al, memb[ds, eax + 41]);          /* mov al, [eax+0x29] */
            ii(0x1014_f415, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_f417, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_f41a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f41d, 5);  call(0x1014_9b07, -0x591b);           /* call 0x10149b07 */
        l_0x1014_f422:
            ii(0x1014_f422, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_f425, 5);  call(0x1014_9fa8, -0x5482);           /* call 0x10149fa8 */
        l_0x1014_f42a:
            ii(0x1014_f42a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_f42c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_f42d, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_f42e, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_f42f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_f430, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_f431, 1);  ret();                                /* ret */
        }
    }
}
