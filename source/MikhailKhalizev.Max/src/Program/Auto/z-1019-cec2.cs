using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_cec2-f4df5ae8")]
        public void Method_1019_cec2()
        {
            ii(0x1019_cec2, 1); pushd(eax);                             /* push eax */
            ii(0x1019_cec3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_cec4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_cec5, 1); pushd(edx);                             /* push edx */
            ii(0x1019_cec6, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_cec9, 4); mov(eax, memd_a32[ss, esp + 0x1c]);     /* mov eax, [esp+0x1c] */
            ii(0x1019_cecd, 4); mov(ecx, memd_a32[ss, esp + 0x1c]);     /* mov ecx, [esp+0x1c] */
            ii(0x1019_ced1, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1019_ced4, 4); mov(eax, memd_a32[ss, esp + 0x20]);     /* mov eax, [esp+0x20] */
            ii(0x1019_ced8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_ceda, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1019_cede, 5); test(eax, 0x7fff_ffff);                 /* test eax, 0x7fffffff */
            ii(0x1019_cee3, 2); if(jnzd(0x1019_cee9, 0x4)) goto l_0x1019_cee9; /* jnz 0x1019cee9 */
            ii(0x1019_cee5, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_cee7, 2); if(jzd(0x1019_cf1e, 0x35)) goto l_0x1019_cf1e; /* jz 0x1019cf1e */
        l_0x1019_cee9:
            ii(0x1019_cee9, 4); mov(edx, memd_a32[ss, esp + 0x6]);      /* mov edx, [esp+0x6] */
            ii(0x1019_ceed, 6); and(edx, 0x7ff0);                       /* and edx, 0x7ff0 */
            ii(0x1019_cef3, 4); mov(ebx, memd_a32[ss, esp + 0x6]);      /* mov ebx, [esp+0x6] */
            ii(0x1019_cef7, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1019_cefd, 6); and(ebx, 0x800f);                       /* and ebx, 0x800f */
            ii(0x1019_cf03, 3); sar(edx, 0x4);                          /* sar edx, 0x4 */
            ii(0x1019_cf06, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1019_cf08, 5); mov(memw_a32[ss, esp + 0x6], bx);       /* mov [esp+0x6], bx */
            ii(0x1019_cf0d, 6); or(ecx, 0x3fe0);                        /* or ecx, 0x3fe0 */
            ii(0x1019_cf13, 6); sub(edx, 0x3fe);                        /* sub edx, 0x3fe */
            ii(0x1019_cf19, 5); mov(memw_a32[ss, esp + 0x6], cx);       /* mov [esp+0x6], cx */
        l_0x1019_cf1e:
            ii(0x1019_cf1e, 4); mov(eax, memd_a32[ss, esp + 0x24]);     /* mov eax, [esp+0x24] */
            ii(0x1019_cf22, 3); fld(memq_a32[ss, esp]);                 /* fld qword [esp] */
            ii(0x1019_cf25, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1019_cf27, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_cf2a, 1); popd(edx);                              /* pop edx */
            ii(0x1019_cf2b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_cf2c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_cf2d, 1); popd(eax);                              /* pop eax */
            ii(0x1019_cf2e, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
