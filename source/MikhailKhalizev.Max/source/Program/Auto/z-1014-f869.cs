using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f869-18b4a0fc")]
        public void Method_1014_f869()
        {
            ii(0x1014_f869, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_f86e, 5);  call(Definitions.sys_check_available_stack_size, 0x1_64df);/* call 0x10165d52 */
            ii(0x1014_f873, 1);  push(esi);                            /* push esi */
            ii(0x1014_f874, 1);  push(edi);                            /* push edi */
            ii(0x1014_f875, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_f876, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_f878, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_f87e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_f881, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_f884, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1014_f887, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1014_f88a, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f88e, 3);  cmp(eax, 9);                          /* cmp eax, 0x9 */
            ii(0x1014_f891, 2);  if(jnz(0x1014_f8ab, 0x18)) goto l_0x1014_f8ab;/* jnz 0x1014f8ab */
            ii(0x1014_f893, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_f896, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_f899, 5);  call(Definitions.sys_strcat, 0x1_6693);/* call 0x10165f31 */
            ii(0x1014_f89e, 3);  mov(edx, memd[ss, ebp + 16]);         /* mov edx, [ebp+0x10] */
            ii(0x1014_f8a1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_f8a4, 5);  call(Definitions.sys_strcat, 0x1_6688);/* call 0x10165f31 */
            ii(0x1014_f8a9, 2);  jmp(0x1014_f8fd, 0x52); goto l_0x1014_f8fd;/* jmp 0x1014f8fd */
        l_0x1014_f8ab:
            ii(0x1014_f8ab, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f8af, 3);  cmp(eax, 5);                          /* cmp eax, 0x5 */
            ii(0x1014_f8b2, 2);  if(jl(0x1014_f8c3, 0xf)) goto l_0x1014_f8c3;/* jl 0x1014f8c3 */
            ii(0x1014_f8b4, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_f8b7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_f8ba, 5);  call(Definitions.sys_strcat, 0x1_6672);/* call 0x10165f31 */
            ii(0x1014_f8bf, 4);  add(memd[ss, ebp - 4], -5 /* 0xfb */);/* add dword [ebp-0x4], 0xfffffffb */
        l_0x1014_f8c3:
            ii(0x1014_f8c3, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_f8c7, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1014_f8ca, 2);  if(jl(0x1014_f8e6, 0x1a)) goto l_0x1014_f8e6;/* jl 0x1014f8e6 */
            ii(0x1014_f8cc, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_f8cf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_f8d2, 5);  call(Definitions.sys_strcat, 0x1_665a);/* call 0x10165f31 */
            ii(0x1014_f8d7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_f8da, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_f8dd, 5);  call(Definitions.sys_strcat, 0x1_664f);/* call 0x10165f31 */
            ii(0x1014_f8e2, 4);  add(memd[ss, ebp - 4], -4 /* 0xfc */);/* add dword [ebp-0x4], 0xfffffffc */
        l_0x1014_f8e6:
            ii(0x1014_f8e6, 3);  dec(memd[ss, ebp - 4]);               /* dec dword [ebp-0x4] */
            ii(0x1014_f8e9, 5);  cmp(memw[ss, ebp - 4], -1 /* 0xff */);/* cmp word [ebp-0x4], 0xffff */
            ii(0x1014_f8ee, 2);  if(jz(0x1014_f8fd, 0xd)) goto l_0x1014_f8fd;/* jz 0x1014f8fd */
            ii(0x1014_f8f0, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_f8f3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_f8f6, 5);  call(Definitions.sys_strcat, 0x1_6636);/* call 0x10165f31 */
            ii(0x1014_f8fb, 2);  jmp(0x1014_f8e6, -0x17); goto l_0x1014_f8e6;/* jmp 0x1014f8e6 */
        l_0x1014_f8fd:
            ii(0x1014_f8fd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_f8ff, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_f900, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_f901, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_f902, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
