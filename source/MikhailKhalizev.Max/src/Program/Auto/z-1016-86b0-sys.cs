using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_86b0-fddf2501")]
        public void /* sys */ Method_1016_86b0()
        {
            ii(0x1016_86b0, 1); push(esi);                              /* push esi */
            ii(0x1016_86b1, 1); push(edi);                              /* push edi */
            ii(0x1016_86b2, 1); push(ebp);                              /* push ebp */
            ii(0x1016_86b3, 4); mov(ebp, memd[ss, esp + 48]);           /* mov ebp, [esp+0x30] */
            ii(0x1016_86b7, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_86b9, 5); call(/* sys */ 0x1016_7dac, -0x912);    /* call 0x10167dac */
            ii(0x1016_86be, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_86c0, 6); or(ebp, 0x1_0000);                      /* or ebp, 0x10000 */
            ii(0x1016_86c6, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_86cd, 2); if(jz(0x1016_86d3, 4)) goto l_0x1016_86d3; /* jz 0x101686d3 */
            ii(0x1016_86cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_86d1, 2); if(jnz(0x1016_86dd, 0xa)) goto l_0x1016_86dd; /* jnz 0x101686dd */
        l_0x1016_86d3:
            ii(0x1016_86d3, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_86d8, 5); jmp(0x1016_874e, 0x71); goto l_0x1016_874e; /* jmp 0x1016874e */
        l_0x1016_86dd:
            ii(0x1016_86dd, 5); cmp(memd[ss, esp + 36], 0);             /* cmp dword [esp+0x24], 0x0 */
            ii(0x1016_86e2, 2); if(jnz(0x1016_86fd, 0x19)) goto l_0x1016_86fd; /* jnz 0x101686fd */
            ii(0x1016_86e4, 5); cmp(memd[ss, esp + 40], 0);             /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_86e9, 2); if(jnz(0x1016_86f2, 7)) goto l_0x1016_86f2; /* jnz 0x101686f2 */
            ii(0x1016_86eb, 5); cmp(memd[ss, esp + 44], 0);             /* cmp dword [esp+0x2c], 0x0 */
            ii(0x1016_86f0, 2); if(jz(0x1016_86fd, 0xb)) goto l_0x1016_86fd; /* jz 0x101686fd */
        l_0x1016_86f2:
            ii(0x1016_86f2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_86f7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_86f8, 1); pop(edi);                               /* pop edi */
            ii(0x1016_86f9, 1); pop(esi);                               /* pop esi */
            ii(0x1016_86fa, 3); ret(0x24); return;                      /* ret 0x24 */
        l_0x1016_86fd:
            ii(0x1016_86fd, 4); mov(eax, memd[ss, esp + 44]);           /* mov eax, [esp+0x2c] */
            ii(0x1016_8701, 1); push(eax);                              /* push eax */
            ii(0x1016_8702, 4); mov(eax, memd[ss, esp + 44]);           /* mov eax, [esp+0x2c] */
            ii(0x1016_8706, 1); push(eax);                              /* push eax */
            ii(0x1016_8707, 4); mov(eax, memd[ss, esp + 44]);           /* mov eax, [esp+0x2c] */
            ii(0x1016_870b, 1); push(eax);                              /* push eax */
            ii(0x1016_870c, 1); push(ebp);                              /* push ebp */
            ii(0x1016_870d, 4); mov(ebp, memd[ss, esp + 48]);           /* mov ebp, [esp+0x30] */
            ii(0x1016_8711, 1); push(ebp);                              /* push ebp */
            ii(0x1016_8712, 4); mov(eax, memd[ss, esp + 48]);           /* mov eax, [esp+0x30] */
            ii(0x1016_8716, 1); push(eax);                              /* push eax */
            ii(0x1016_8717, 4); mov(ebp, memd[ss, esp + 48]);           /* mov ebp, [esp+0x30] */
            ii(0x1016_871b, 1); push(ebp);                              /* push ebp */
            ii(0x1016_871c, 4); mov(eax, memd[ss, esp + 48]);           /* mov eax, [esp+0x30] */
            ii(0x1016_8720, 1); push(eax);                              /* push eax */
            ii(0x1016_8721, 4); mov(ebp, memd[ss, esp + 48]);           /* mov ebp, [esp+0x30] */
            ii(0x1016_8725, 1); push(ebp);                              /* push ebp */
            ii(0x1016_8726, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_8728, 5); call(/* sys */ 0x1016_8c64, 0x537);     /* call 0x10168c64 */
            ii(0x1016_872d, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_872f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8731, 2); if(jnz(0x1016_873e, 0xb)) goto l_0x1016_873e; /* jnz 0x1016873e */
            ii(0x1016_8733, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_8738, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_8739, 1); pop(edi);                               /* pop edi */
            ii(0x1016_873a, 1); pop(esi);                               /* pop esi */
            ii(0x1016_873b, 3); ret(0x24); return;                      /* ret 0x24 */
        l_0x1016_873e:
            ii(0x1016_873e, 2); push(0);                                /* push 0x0 */
            ii(0x1016_8740, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_8742, 3); mov(ebx, memd[ds, eax + 48]);           /* mov ebx, [eax+0x30] */
            ii(0x1016_8745, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_8747, 5); call(/* sys */ 0x1016_9b90, 0x1444);    /* call 0x10169b90 */
            ii(0x1016_874c, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
        l_0x1016_874e:
            ii(0x1016_874e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_874f, 1); pop(edi);                               /* pop edi */
            ii(0x1016_8750, 1); pop(esi);                               /* pop esi */
            ii(0x1016_8751, 3); ret(0x24);                              /* ret 0x24 */
        }
    }
}
