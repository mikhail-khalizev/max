using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("06365d13-71c5-46ae-aab6-ea89f3e3de12")]
        public void Method_100c_120a()
        {
            ii(0x100c_120a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_120f, 5); calld(Definitions.sys_check_available_stack_size, 0xa4b3e); /* call 0x10165d52 */
            ii(0x100c_1214, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_1215, 1); pushd(esi);                             /* push esi */
            ii(0x100c_1216, 1); pushd(edi);                             /* push edi */
            ii(0x100c_1217, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_1218, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_121a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_1220, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_1223, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_1226, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_1229, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_122c, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100c_122f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_1234, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_1236, 2); if(jzd(0x100c_1241, 0x9)) goto l_0x100c_1241; /* jz 0x100c1241 */
            ii(0x100c_1238, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_123b, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100c_123f, 2); if(jnzd(0x100c_1243, 0x2)) goto l_0x100c_1243; /* jnz 0x100c1243 */
        l_0x100c_1241:
            ii(0x100c_1241, 2); jmpd(0x100c_124c, 0x9); goto l_0x100c_124c; /* jmp 0x100c124c */
        l_0x100c_1243:
            ii(0x100c_1243, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_1246, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_124a, 2); if(jnzd(0x100c_124e, 0x2)) goto l_0x100c_124e; /* jnz 0x100c124e */
        l_0x100c_124c:
            ii(0x100c_124c, 2); jmpd(0x100c_125d, 0xf); goto l_0x100c_125d; /* jmp 0x100c125d */
        l_0x100c_124e:
            ii(0x100c_124e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_1251, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100c_1254, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_1259, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_125b, 2); if(jgd(0x100c_125f, 0x2)) goto l_0x100c_125f; /* jg 0x100c125f */
        l_0x100c_125d:
            ii(0x100c_125d, 2); jmpd(0x100c_1275, 0x16); goto l_0x100c_1275; /* jmp 0x100c1275 */
        l_0x100c_125f:
            ii(0x100c_125f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100c_1263, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_1266, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_1269, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_126c, 5); calld(0x1007_49d4, -0x4c89d);           /* call 0x100749d4 */
            ii(0x100c_1271, 2); test(al, al);                           /* test al, al */
            ii(0x100c_1273, 2); if(jnzd(0x100c_127b, 0x6)) goto l_0x100c_127b; /* jnz 0x100c127b */
        l_0x100c_1275:
            ii(0x100c_1275, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_1279, 2); jmpd(0x100c_12c3, 0x48); goto l_0x100c_12c3; /* jmp 0x100c12c3 */
        l_0x100c_127b:
            ii(0x100c_127b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_127e, 5); cmp(memw_a32[ds, eax + 0x8], 0x29);     /* cmp word [eax+0x8], 0x29 */
            ii(0x100c_1283, 2); if(jzd(0x100c_128f, 0xa)) goto l_0x100c_128f; /* jz 0x100c128f */
            ii(0x100c_1285, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_1288, 5); cmp(memw_a32[ds, eax + 0x8], 0x2a);     /* cmp word [eax+0x8], 0x2a */
            ii(0x100c_128d, 2); if(jnzd(0x100c_1295, 0x6)) goto l_0x100c_1295; /* jnz 0x100c1295 */
        l_0x100c_128f:
            ii(0x100c_128f, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_1293, 2); jmpd(0x100c_12c3, 0x2e); goto l_0x100c_12c3; /* jmp 0x100c12c3 */
        l_0x100c_1295:
            ii(0x100c_1295, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_1298, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100c_129d, 2); if(jzd(0x100c_12a9, 0xa)) goto l_0x100c_12a9; /* jz 0x100c12a9 */
            ii(0x100c_129f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_12a2, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x100c_12a7, 2); if(jnzd(0x100c_12bf, 0x16)) goto l_0x100c_12bf; /* jnz 0x100c12bf */
        l_0x100c_12a9:
            ii(0x100c_12a9, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_12ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_12b0, 5); calld(0x1007_6074, -0x4b241);           /* call 0x10076074 */
            ii(0x100c_12b5, 2); test(al, al);                           /* test al, al */
            ii(0x100c_12b7, 2); if(jnzd(0x100c_12bf, 0x6)) goto l_0x100c_12bf; /* jnz 0x100c12bf */
            ii(0x100c_12b9, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_12bd, 2); jmpd(0x100c_12c3, 0x4); goto l_0x100c_12c3; /* jmp 0x100c12c3 */
        l_0x100c_12bf:
            ii(0x100c_12bf, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x100c_12c3:
            ii(0x100c_12c3, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100c_12c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_12c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_12c9, 1); popd(edi);                              /* pop edi */
            ii(0x100c_12ca, 1); popd(esi);                              /* pop esi */
            ii(0x100c_12cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_12cc, 1); retd(); return;                         /* ret */
        }
    }
}
