using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7af26c69-31e6-4563-8a4d-07bb2c191222")]
        public void /* sys */ Method_1019_4e9d()
        {
            ii(0x1019_4e9d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4e9e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4ea0, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4ea1, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4ea2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4ea3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4ea4, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4ea6, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4ea8, 1); pushd(es);                              /* push es */
            ii(0x1019_4ea9, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1019_4eae, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_4eb2, 3); calld_a32_far_ind(ss, ebp + 0x8);       /* call far dword [ebp+0x8] */
            ii(0x1019_4eb5, 1); pushd(ds);                              /* push ds */
            ii(0x1019_4eb6, 1); pushd(es);                              /* push es */
            ii(0x1019_4eb7, 3); les(edi, ss, ebp + 0x18);               /* les edi, [ebp+0x18] */
            ii(0x1019_4eba, 3); lds(esi, ss, ebp + 0x10);               /* lds esi, [ebp+0x10] */
            ii(0x1019_4ebd, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_4ebf, 5); mov(ecx, 0x6a);                         /* mov ecx, 0x6a */
            ii(0x1019_4ec4, 1); cld();                                  /* cld */
            ii(0x1019_4ec5, 2); rep_a32(() => movsb_a32());             /* rep movsb */
            ii(0x1019_4ec7, 3); les(edi, ss, ebp + 0x18);               /* les edi, [ebp+0x18] */
            ii(0x1019_4eca, 5); mov(memw_a32[es, edi + 0x44], ds);      /* mov [es:edi+0x44], ds */
            ii(0x1019_4ecf, 5); mov(memw_a32[es, edi + 0x4c], ds);      /* mov [es:edi+0x4c], ds */
            ii(0x1019_4ed4, 5); mov(memw_a32[es, edi + 0x54], ds);      /* mov [es:edi+0x54], ds */
            ii(0x1019_4ed9, 5); mov(memw_a32[es, edi + 0x5c], ds);      /* mov [es:edi+0x5c], ds */
            ii(0x1019_4ede, 1); popd(es);                               /* pop es */
            ii(0x1019_4edf, 1); popd(ds);                               /* pop ds */
            ii(0x1019_4ee0, 1); popd(es);                               /* pop es */
            ii(0x1019_4ee1, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4ee3, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4ee5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4ee6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4ee7, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4ee8, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4ee9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4eea, 1); retd(); return;                         /* ret */
        }
    }
}
