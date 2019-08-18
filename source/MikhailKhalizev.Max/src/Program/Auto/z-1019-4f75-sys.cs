using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a78d123-3eff-4b05-bcf1-37c5b3cba94f")]
        public void /* sys */ Method_1019_4f75()
        {
            ii(0x1019_4f75, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4f76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4f78, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4f79, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4f7a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4f7b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4f7c, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4f7e, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4f80, 1); pushd(es);                              /* push es */
            ii(0x1019_4f81, 1); pushd(es);                              /* push es */
            ii(0x1019_4f82, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1019_4f87, 4); lfs(edi, ss, ebp + 0x10);               /* lfs edi, [ebp+0x10] */
            ii(0x1019_4f8b, 3); calld_a32_far_ind(ss, ebp + 0x8);       /* call far dword [ebp+0x8] */
            ii(0x1019_4f8e, 1); pushd(ds);                              /* push ds */
            ii(0x1019_4f8f, 3); les(edi, ss, ebp + 0x18);               /* les edi, [ebp+0x18] */
            ii(0x1019_4f92, 3); lds(esi, ss, ebp + 0x10);               /* lds esi, [ebp+0x10] */
            ii(0x1019_4f95, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_4f97, 5); mov(ecx, 0x6a);                         /* mov ecx, 0x6a */
            ii(0x1019_4f9c, 1); cld();                                  /* cld */
            ii(0x1019_4f9d, 2); rep_a32(() => movsb_a32());             /* rep movsb */
            ii(0x1019_4f9f, 3); les(edi, ss, ebp + 0x18);               /* les edi, [ebp+0x18] */
            ii(0x1019_4fa2, 5); mov(memw_a32[es, edi + 0x44], ds);      /* mov [es:edi+0x44], ds */
            ii(0x1019_4fa7, 5); mov(memw_a32[es, edi + 0x4c], ds);      /* mov [es:edi+0x4c], ds */
            ii(0x1019_4fac, 5); mov(memw_a32[es, edi + 0x54], ds);      /* mov [es:edi+0x54], ds */
            ii(0x1019_4fb1, 5); mov(memw_a32[es, edi + 0x5c], ds);      /* mov [es:edi+0x5c], ds */
            ii(0x1019_4fb6, 1); popd(ds);                               /* pop ds */
            ii(0x1019_4fb7, 1); popd(es);                               /* pop es */
            ii(0x1019_4fb8, 1); popd(es);                               /* pop es */
            ii(0x1019_4fb9, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4fbb, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4fbd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4fbe, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4fbf, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4fc0, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4fc1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4fc2, 1); retd(); return;                         /* ret */
        }
    }
}
