using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_8f18-55f6c925")]
        public void /* sys */ Method_1017_8f18()
        {
            ii(0x1017_8f18, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_8f19, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_8f1a, 1);  push(esi);                            /* push esi */
            ii(0x1017_8f1b, 1);  push(edi);                            /* push edi */
            ii(0x1017_8f1c, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_8f1e, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x1017_8f20, 1);  cli();                                /* cli */
            ii(0x1017_8f21, 5);  mov(eax, memd[ds, 0x101b_e1ec]);      /* mov eax, [0x101be1ec] */
            ii(0x1017_8f26, 6);  mov(esi, memd[ds, 0x101b_e1e8]);      /* mov esi, [0x101be1e8] */
            ii(0x1017_8f2c, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
            ii(0x1017_8f31, 2);  cmp(eax, esi);                        /* cmp eax, esi */
            ii(0x1017_8f33, 2);  if(jz(0x1017_8f6f, 0x3a)) goto l_0x1017_8f6f;/* jz 0x10178f6f */
            ii(0x1017_8f35, 2);  cmp(esi, eax);                        /* cmp esi, eax */
            ii(0x1017_8f37, 2);  if(jle(0x1017_8f46, 0xd)) goto l_0x1017_8f46;/* jle 0x10178f46 */
            ii(0x1017_8f39, 6);  mov(edi, memd[ds, 0x101b_e1ec]);      /* mov edi, [0x101be1ec] */
            ii(0x1017_8f3f, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1017_8f41, 2);  sub(eax, edi);                        /* sub eax, edi */
            ii(0x1017_8f43, 1);  dec(eax);                             /* dec eax */
            ii(0x1017_8f44, 2);  jmp(0x1017_8f54, 0xe); goto l_0x1017_8f54;/* jmp 0x10178f54 */
        l_0x1017_8f46:
            ii(0x1017_8f46, 5);  mov(eax, 0x40);                       /* mov eax, 0x40 */
            ii(0x1017_8f4b, 6);  sub(eax, memd[ds, 0x101b_e1ec]);      /* sub eax, [0x101be1ec] */
            ii(0x1017_8f51, 1);  dec(eax);                             /* dec eax */
            ii(0x1017_8f52, 2);  add(eax, esi);                        /* add eax, esi */
        l_0x1017_8f54:
            ii(0x1017_8f54, 2);  cmp(ebx, eax);                        /* cmp ebx, eax */
            ii(0x1017_8f56, 2);  if(jg(0x1017_8f6f, 0x17)) goto l_0x1017_8f6f;/* jg 0x10178f6f */
            ii(0x1017_8f58, 6);  add(ebx, memd[ds, 0x101b_e1ec]);      /* add ebx, [0x101be1ec] */
            ii(0x1017_8f5e, 3);  and(ebx, 0x3f);                       /* and ebx, 0x3f */
            ii(0x1017_8f61, 5);  mov(eax, 0x1020_8940);                /* mov eax, 0x10208940 */
            ii(0x1017_8f66, 3);  shl(ebx, 2);                          /* shl ebx, 0x2 */
            ii(0x1017_8f69, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1017_8f6b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_8f6d, 2);  mov(memd[ds, ecx], eax);              /* mov [ecx], eax */
        l_0x1017_8f6f:
            ii(0x1017_8f6f, 1);  sti();                                /* sti */
            ii(0x1017_8f70, 1);  cld();                                /* cld */
            ii(0x1017_8f71, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_8f73, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_8f74, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_8f75, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_8f76, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_8f77, 1);  ret();                                /* ret */
        }
    }
}
