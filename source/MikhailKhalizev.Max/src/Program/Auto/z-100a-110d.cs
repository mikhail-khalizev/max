using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5945702-5ed8-4d51-90e3-82bcf62a8bb9")]
        public void Method_100a_110d()
        {
            ii(0x100a_110d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_1112, 5); calld(Definitions.sys_check_available_stack_size, 0xc4c3b); /* call 0x10165d52 */
            ii(0x100a_1117, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_1118, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_1119, 1); pushd(esi);                             /* push esi */
            ii(0x100a_111a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_111b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_111c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_111e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_1124, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_1127, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_112a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_112d, 5); calld(0x100a_04b1, -0xc81);             /* call 0x100a04b1 */
            ii(0x100a_1132, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1135, 4); mov(ax, memw_a32[ds, eax + 0x30]);      /* mov ax, [eax+0x30] */
            ii(0x100a_1139, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100a_113d, 2); if(jged(0x100a_1148, 0x9)) goto l_0x100a_1148; /* jge 0x100a1148 */
            ii(0x100a_113f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1142, 4); cmp(memb_a32[ds, eax + 0x4c], 0);       /* cmp byte [eax+0x4c], 0x0 */
            ii(0x100a_1146, 2); if(jnzd(0x100a_114a, 0x2)) goto l_0x100a_114a; /* jnz 0x100a114a */
        l_0x100a_1148:
            ii(0x100a_1148, 2); jmpd(0x100a_1198, 0x4e); goto l_0x100a_1198; /* jmp 0x100a1198 */
        l_0x100a_114a:
            ii(0x100a_114a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_114d, 7); mov(dx, memw_a32[ds, eax + 0x36f]);     /* mov dx, [eax+0x36f] */
            ii(0x100a_1154, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1157, 7); cmp(dx, memw_a32[ds, eax + 0x373]);     /* cmp dx, [eax+0x373] */
            ii(0x100a_115e, 2); if(jled(0x100a_1171, 0x11)) goto l_0x100a_1171; /* jle 0x100a1171 */
            ii(0x100a_1160, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_1165, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1168, 5); calld(0x100a_106c, -0x101);             /* call 0x100a106c */
            ii(0x100a_116d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_116f, 2); if(jnzd(0x100a_1173, 0x2)) goto l_0x100a_1173; /* jnz 0x100a1173 */
        l_0x100a_1171:
            ii(0x100a_1171, 2); jmpd(0x100a_1175, 0x2); goto l_0x100a_1175; /* jmp 0x100a1175 */
        l_0x100a_1173:
            ii(0x100a_1173, 2); jmpd(0x100a_1198, 0x23); goto l_0x100a_1198; /* jmp 0x100a1198 */
        l_0x100a_1175:
            ii(0x100a_1175, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1178, 7); mov(dx, memw_a32[ds, eax + 0x36d]);     /* mov dx, [eax+0x36d] */
            ii(0x100a_117f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1182, 7); cmp(dx, memw_a32[ds, eax + 0x371]);     /* cmp dx, [eax+0x371] */
            ii(0x100a_1189, 2); if(jled(0x100a_1198, 0xd)) goto l_0x100a_1198; /* jle 0x100a1198 */
            ii(0x100a_118b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_1190, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1193, 5); calld(0x100a_106c, -0x12c);             /* call 0x100a106c */
        l_0x100a_1198:
            ii(0x100a_1198, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_119a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_119b, 1); popd(edi);                              /* pop edi */
            ii(0x100a_119c, 1); popd(esi);                              /* pop esi */
            ii(0x100a_119d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_119e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_119f, 1); retd(); return;                         /* ret */
        }
    }
}
