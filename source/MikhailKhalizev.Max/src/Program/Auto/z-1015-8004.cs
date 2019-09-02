using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8004-4ad8f7ab")]
        public void Method_1015_8004()
        {
            ii(0x1015_8004, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_8009, 5); call(Definitions.sys_check_available_stack_size, 0xdd44); /* call 0x10165d52 */
            ii(0x1015_800e, 1); push(ebx);                              /* push ebx */
            ii(0x1015_800f, 1); push(ecx);                              /* push ecx */
            ii(0x1015_8010, 1); push(esi);                              /* push esi */
            ii(0x1015_8011, 1); push(edi);                              /* push edi */
            ii(0x1015_8012, 1); push(ebp);                              /* push ebp */
            ii(0x1015_8013, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8015, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_801b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_801e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_8021, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_8024, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_8027, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_802c, 5); call(0x100f_448c, -0x6_3ba5);           /* call 0x100f448c */
            ii(0x1015_8031, 5); call(0x100f_f5c1, -0x5_8a75);           /* call 0x100ff5c1 */
            ii(0x1015_8036, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8038, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_803b, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_803e, 5); call(0x1007_6a34, -0xe_160f);           /* call 0x10076a34 */
            ii(0x1015_8043, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_8046, 4); mov(memb[ds, eax + 0x5b], 0);           /* mov byte [eax+0x5b], 0x0 */
            ii(0x1015_804a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_804d, 4); mov(memb[ds, eax + 0x5c], 0);           /* mov byte [eax+0x5c], 0x0 */
            ii(0x1015_8051, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1015_8058, 2); if(jz(0x1015_8062, 8)) goto l_0x1015_8062; /* jz 0x10158062 */
            ii(0x1015_805a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_805d, 5); call(0x1012_ae8d, -0x2_d1d5);           /* call 0x1012ae8d */
        l_0x1015_8062:
            ii(0x1015_8062, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_8065, 4); cmp(memb[ds, eax + 0x3d], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x1015_8069, 2); if(jnz(0x1015_8084, 0x19)) goto l_0x1015_8084; /* jnz 0x10158084 */
            ii(0x1015_806b, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_8070, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8072, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_8075, 5); call(0x1016_3053, 0xafd9);              /* call 0x10163053 */
            ii(0x1015_807a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_807d, 5); call(0x1010_094d, -0x5_7735);           /* call 0x1010094d */
            ii(0x1015_8082, 2); jmp(0x1015_80a6, 0x22); goto l_0x1015_80a6; /* jmp 0x101580a6 */
        l_0x1015_8084:
            ii(0x1015_8084, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_8089, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1015_808e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_8091, 5); call(0x1016_3053, 0xafbd);              /* call 0x10163053 */
            ii(0x1015_8096, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_8099, 5); call(0x1010_094d, -0x5_7751);           /* call 0x1010094d */
            ii(0x1015_809e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_80a1, 5); call(0x1010_19b8, -0x5_66ee);           /* call 0x101019b8 */
        l_0x1015_80a6:
            ii(0x1015_80a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_80a8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_80a9, 1); pop(edi);                               /* pop edi */
            ii(0x1015_80aa, 1); pop(esi);                               /* pop esi */
            ii(0x1015_80ab, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_80ac, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_80ad, 1); ret();                                  /* ret */
        }
    }
}
