using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_c020-b49e113d")]
        public void Method_1028_c020()
        {
            ii(0x1028_c020, 2);  pusha();                              /* pusha */
            ii(0x1028_c022, 1);  pushd(ds);                            /* push ds */
            ii(0x1028_c023, 1);  popd(es);                             /* pop es */
            ii(0x1028_c024, 10);  mov(memd[ds, 0x1378], 0xffff_ffff);  /* mov dword [0x1378], 0xffffffff */
            ii(0x1028_c02e, 10);  mov(memd[ds, 0x1384], 0xffff_ffff);  /* mov dword [0x1384], 0xffffffff */
            ii(0x1028_c038, 5);  mov(esi, 0x1af9);                     /* mov esi, 0x1af9 */
            ii(0x1028_c03d, 5);  mov(edi, 0x2104);                     /* mov edi, 0x2104 */
            ii(0x1028_c042, 7);  movzx(eax, memw[ds, 0x13a4]);         /* movzx eax, word [0x13a4] */
            ii(0x1028_c049, 5);  mov(ebx, 0x200);                      /* mov ebx, 0x200 */
            ii(0x1028_c04e, 3);  mul(bx);                              /* mul bx */
            ii(0x1028_c051, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x1028_c053, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1028_c055, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
        l_0x1028_c057:
            ii(0x1028_c057, 1);  lodsb();                              /* lodsb */
            ii(0x1028_c058, 2);  cmp(al, -1 /* 0xff */);               /* cmp al, 0xff */
            ii(0x1028_c05a, 6);  if(jz(0x1028_c0fe, 0x9e)) goto l_0x1028_c0fe;/* jz 0x1028c0fe */
            ii(0x1028_c060, 2);  mov(bl, 0xa);                         /* mov bl, 0xa */
            ii(0x1028_c062, 2);  mul(bl);                              /* mul bl */
            ii(0x1028_c064, 5);  mov(edx, 0x15);                       /* mov edx, 0x15 */
            ii(0x1028_c069, 3);  add(ax, dx);                          /* add ax, dx */
            ii(0x1028_c06c, 3);  movzx(ebx, ax);                       /* movzx ebx, ax */
            ii(0x1028_c06f, 1);  push(esi);                            /* push esi */
            ii(0x1028_c070, 2);  mov(esi, memd[ds, ebx]);              /* mov esi, [ebx] */
            ii(0x1028_c072, 5);  cmp(memw[ds, ebx + 4], 1);            /* cmp word [ebx+0x4], 0x1 */
            ii(0x1028_c077, 2);  if(jnz(0x1028_c08a, 0x11)) goto l_0x1028_c08a;/* jnz 0x1028c08a */
            ii(0x1028_c079, 7);  cmp(memd[ds, 0x1378], -1 /* 0xff */); /* cmp dword [0x1378], 0xffffffff */
            ii(0x1028_c080, 2);  if(jnz(0x1028_c0f0, 0x6e)) goto l_0x1028_c0f0;/* jnz 0x1028c0f0 */
            ii(0x1028_c082, 6);  mov(memd[ds, 0x1378], edi);           /* mov [0x1378], edi */
            ii(0x1028_c088, 2);  jmp(0x1028_c0f0, 0x66); goto l_0x1028_c0f0;/* jmp 0x1028c0f0 */
        l_0x1028_c08a:
            ii(0x1028_c08a, 5);  cmp(memw[ds, ebx + 6], 1);            /* cmp word [ebx+0x6], 0x1 */
            ii(0x1028_c08f, 2);  if(jnz(0x1028_c0b1, 0x20)) goto l_0x1028_c0b1;/* jnz 0x1028c0b1 */
            ii(0x1028_c091, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1028_c093, 6);  sub(eax, memd[ds, 0x1378]);           /* sub eax, [0x1378] */
            ii(0x1028_c099, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1028_c09c, 6);  mov(ebx, memd[ds, 0x1378]);           /* mov ebx, [0x1378] */
            ii(0x1028_c0a2, 3);  mov(memd[ds, ebx + 2], eax);          /* mov [ebx+0x2], eax */
            ii(0x1028_c0a5, 10);  mov(memd[ds, 0x1378], 0xffff_ffff);  /* mov dword [0x1378], 0xffffffff */
            ii(0x1028_c0af, 2);  jmp(0x1028_c0f0, 0x3f); goto l_0x1028_c0f0;/* jmp 0x1028c0f0 */
        l_0x1028_c0b1:
            ii(0x1028_c0b1, 5);  cmp(memw[ds, ebx + 4], 2);            /* cmp word [ebx+0x4], 0x2 */
            ii(0x1028_c0b6, 2);  if(jnz(0x1028_c0d6, 0x1e)) goto l_0x1028_c0d6;/* jnz 0x1028c0d6 */
            ii(0x1028_c0b8, 2);  mov(eax, edi);                        /* mov eax, edi */
            ii(0x1028_c0ba, 6);  sub(eax, memd[ds, 0x1384]);           /* sub eax, [0x1384] */
            ii(0x1028_c0c0, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1028_c0c3, 2);  neg(eax);                             /* neg eax */
            ii(0x1028_c0c5, 3);  mov(memd[ds, esi + 2], eax);          /* mov [esi+0x2], eax */
            ii(0x1028_c0c8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1028_c0ca, 10);  mov(memd[ds, 0x1384], 0xffff_ffff);  /* mov dword [0x1384], 0xffffffff */
            ii(0x1028_c0d4, 2);  jmp(0x1028_c0f0, 0x1a); goto l_0x1028_c0f0;/* jmp 0x1028c0f0 */
        l_0x1028_c0d6:
            ii(0x1028_c0d6, 5);  cmp(memw[ds, ebx + 6], 2);            /* cmp word [ebx+0x6], 0x2 */
            ii(0x1028_c0db, 6);  if(jnz(0x1028_c0f0, 0xf)) goto l_0x1028_c0f0;/* jnz 0x1028c0f0 */
            ii(0x1028_c0e1, 7);  cmp(memd[ds, 0x1384], -1 /* 0xff */); /* cmp dword [0x1384], 0xffffffff */
            ii(0x1028_c0e8, 2);  if(jnz(0x1028_c0f0, 6)) goto l_0x1028_c0f0;/* jnz 0x1028c0f0 */
            ii(0x1028_c0ea, 6);  mov(memd[ds, 0x1384], edi);           /* mov [0x1384], edi */
        l_0x1028_c0f0:
            ii(0x1028_c0f0, 1);  lodsb();                              /* lodsb */
            ii(0x1028_c0f1, 2);  cmp(al, -0x70 /* 0x90 */);            /* cmp al, 0x90 */
            ii(0x1028_c0f3, 2);  if(jz(0x1028_c0f8, 3)) goto l_0x1028_c0f8;/* jz 0x1028c0f8 */
            ii(0x1028_c0f5, 1);  stosb();                              /* stosb */
            ii(0x1028_c0f6, 2);  jmp(0x1028_c0f0, -8); goto l_0x1028_c0f0;/* jmp 0x1028c0f0 */
        l_0x1028_c0f8:
            ii(0x1028_c0f8, 1);  pop(esi);                             /* pop esi */
            ii(0x1028_c0f9, 5);  jmp(0x1028_c057, -0xa7); goto l_0x1028_c057;/* jmp 0x1028c057 */
        l_0x1028_c0fe:
            ii(0x1028_c0fe, 2);  popa();                               /* popa */
            ii(0x1028_c100, 1);  ret();                                /* ret */
        }
    }
}
