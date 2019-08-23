using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1c5c-e59eda79")]
        public void /* sys */ Method_1017_1c5c()
        {
            ii(0x1017_1c5c, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1c5d, 1); push(esi);                              /* push esi */
            ii(0x1017_1c5e, 1); push(edi);                              /* push edi */
            ii(0x1017_1c5f, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1c60, 4); mov(ebp, memd[ss, esp + 0x20]);         /* mov ebp, [esp+0x20] */
            ii(0x1017_1c64, 4); mov(ebx, memd[ss, esp + 0x28]);         /* mov ebx, [esp+0x28] */
            ii(0x1017_1c68, 4); mov(edi, memd[ss, esp + 0x30]);         /* mov edi, [esp+0x30] */
            ii(0x1017_1c6c, 3); cmp(ebx, 0x4);                          /* cmp ebx, 0x4 */
            ii(0x1017_1c6f, 6); if(jb(0x1017_1d11, 0x9c)) goto l_0x1017_1d11; /* jb 0x10171d11 */
            ii(0x1017_1c75, 2); mov(esi, edi);                          /* mov esi, edi */
            ii(0x1017_1c77, 3); and(esi, 0x3);                          /* and esi, 0x3 */
            ii(0x1017_1c7a, 2); if(jz(0x1017_1cb4, 0x38)) goto l_0x1017_1cb4; /* jz 0x10171cb4 */
            ii(0x1017_1c7c, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1017_1c80, 1); push(edx);                              /* push edx */
            ii(0x1017_1c81, 1); push(edi);                              /* push edi */
            ii(0x1017_1c82, 4); mov(ecx, memd[ss, esp + 0x34]);         /* mov ecx, [esp+0x34] */
            ii(0x1017_1c86, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1017_1c8b, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1c8c, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1017_1c8e, 1); push(eax);                              /* push eax */
            ii(0x1017_1c8f, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_1c91, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1017_1c95, 1); push(eax);                              /* push eax */
            ii(0x1017_1c96, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1c97, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1017_1c9b, 1); push(edx);                              /* push edx */
            ii(0x1017_1c9c, 4); mov(ecx, memd[ss, esp + 0x34]);         /* mov ecx, [esp+0x34] */
            ii(0x1017_1ca0, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1ca1, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1017_1ca5, 2); add(edi, esi);                          /* add edi, esi */
            ii(0x1017_1ca7, 1); push(eax);                              /* push eax */
            ii(0x1017_1ca8, 2); sub(ebx, esi);                          /* sub ebx, esi */
            ii(0x1017_1caa, 2); add(ebp, esi);                          /* add ebp, esi */
            ii(0x1017_1cac, 5); call(Definitions.sys_display_copy_to_video_memory_1, 0x1_b143); /* call 0x1018cdf4 */
            ii(0x1017_1cb1, 3); add(esp, 0x24);                         /* add esp, 0x24 */
        l_0x1017_1cb4:
            ii(0x1017_1cb4, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1017_1cb6, 3); and(esi, 0x3);                          /* and esi, 0x3 */
            ii(0x1017_1cb9, 2); sub(ebx, esi);                          /* sub ebx, esi */
            ii(0x1017_1cbb, 2); if(jz(0x1017_1ce6, 0x29)) goto l_0x1017_1ce6; /* jz 0x10171ce6 */
            ii(0x1017_1cbd, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1017_1cc1, 1); push(edx);                              /* push edx */
            ii(0x1017_1cc2, 1); push(edi);                              /* push edi */
            ii(0x1017_1cc3, 4); mov(ecx, memd[ss, esp + 0x34]);         /* mov ecx, [esp+0x34] */
            ii(0x1017_1cc7, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1cc8, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1cc9, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1017_1ccd, 1); push(eax);                              /* push eax */
            ii(0x1017_1cce, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1ccf, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1017_1cd3, 1); push(edx);                              /* push edx */
            ii(0x1017_1cd4, 4); mov(ecx, memd[ss, esp + 0x34]);         /* mov ecx, [esp+0x34] */
            ii(0x1017_1cd8, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1cd9, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1017_1cdd, 1); push(eax);                              /* push eax */
            ii(0x1017_1cde, 5); call(Definitions.sys_display_copy_to_video_memory_2, 0x1_b351); /* call 0x1018d034 */
            ii(0x1017_1ce3, 3); add(esp, 0x24);                         /* add esp, 0x24 */
        l_0x1017_1ce6:
            ii(0x1017_1ce6, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_1ce8, 2); if(jz(0x1017_1d3a, 0x50)) goto l_0x1017_1d3a; /* jz 0x10171d3a */
            ii(0x1017_1cea, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1017_1cee, 1); push(edx);                              /* push edx */
            ii(0x1017_1cef, 2); add(edi, ebx);                          /* add edi, ebx */
            ii(0x1017_1cf1, 1); push(edi);                              /* push edi */
            ii(0x1017_1cf2, 2); add(ebp, ebx);                          /* add ebp, ebx */
            ii(0x1017_1cf4, 4); mov(ebx, memd[ss, esp + 0x34]);         /* mov ebx, [esp+0x34] */
            ii(0x1017_1cf8, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1cf9, 1); push(esi);                              /* push esi */
            ii(0x1017_1cfa, 4); mov(ecx, memd[ss, esp + 0x34]);         /* mov ecx, [esp+0x34] */
            ii(0x1017_1cfe, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1cff, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1d00, 4); mov(esi, memd[ss, esp + 0x34]);         /* mov esi, [esp+0x34] */
            ii(0x1017_1d04, 1); push(esi);                              /* push esi */
            ii(0x1017_1d05, 4); mov(edi, memd[ss, esp + 0x34]);         /* mov edi, [esp+0x34] */
            ii(0x1017_1d09, 1); push(edi);                              /* push edi */
            ii(0x1017_1d0a, 4); mov(ebp, memd[ss, esp + 0x34]);         /* mov ebp, [esp+0x34] */
            ii(0x1017_1d0e, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1d0f, 2); jmp(0x1017_1d32, 0x21); goto l_0x1017_1d32; /* jmp 0x10171d32 */
        l_0x1017_1d11:
            ii(0x1017_1d11, 4); mov(edx, memd[ss, esp + 0x34]);         /* mov edx, [esp+0x34] */
            ii(0x1017_1d15, 1); push(edx);                              /* push edx */
            ii(0x1017_1d16, 1); push(edi);                              /* push edi */
            ii(0x1017_1d17, 4); mov(ecx, memd[ss, esp + 0x34]);         /* mov ecx, [esp+0x34] */
            ii(0x1017_1d1b, 1); push(ecx);                              /* push ecx */
            ii(0x1017_1d1c, 1); push(ebx);                              /* push ebx */
            ii(0x1017_1d1d, 4); mov(esi, memd[ss, esp + 0x34]);         /* mov esi, [esp+0x34] */
            ii(0x1017_1d21, 1); push(esi);                              /* push esi */
            ii(0x1017_1d22, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1d23, 4); mov(edi, memd[ss, esp + 0x34]);         /* mov edi, [esp+0x34] */
            ii(0x1017_1d27, 1); push(edi);                              /* push edi */
            ii(0x1017_1d28, 4); mov(ebp, memd[ss, esp + 0x34]);         /* mov ebp, [esp+0x34] */
            ii(0x1017_1d2c, 1); push(ebp);                              /* push ebp */
            ii(0x1017_1d2d, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1017_1d31, 1); push(eax);                              /* push eax */
        l_0x1017_1d32:
            ii(0x1017_1d32, 5); call(Definitions.sys_display_copy_to_video_memory_1, 0x1_b0bd); /* call 0x1018cdf4 */
            ii(0x1017_1d37, 3); add(esp, 0x24);                         /* add esp, 0x24 */
        l_0x1017_1d3a:
            ii(0x1017_1d3a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_1d3b, 1); pop(edi);                               /* pop edi */
            ii(0x1017_1d3c, 1); pop(esi);                               /* pop esi */
            ii(0x1017_1d3d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_1d3e, 1); ret();                                  /* ret */
        }
    }
}
