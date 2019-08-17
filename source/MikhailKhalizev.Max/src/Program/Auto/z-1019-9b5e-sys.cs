using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("75d4ae5b-c6d5-4795-882f-aa73fcce7628")]
        public void /* sys */ Method_1019_9b5e()
        {
            ii(0x1019_9b5e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_9b5f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_9b60, 1); pushd(es);                              /* push es */
            ii(0x1019_9b61, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1019_9b63, 6); mov(dl, memb_a32[ds, 0x101c_1c41]);     /* mov dl, [0x101c1c41] */
            ii(0x1019_9b69, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1019_9b6b, 2); if(jzd(0x1019_9b8d, 0x20)) goto l_0x1019_9b8d; /* jz 0x10199b8d */
            ii(0x1019_9b6d, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1019_9b6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_9b71, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_9b73, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_9b75, 2); mov(al, 0x21);                          /* mov al, 0x21 */
            ii(0x1019_9b77, 2); mov(ah, 0xfa);                          /* mov ah, 0xfa */
            ii(0x1019_9b79, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9b7b, 2); mov(al, 0x1f);                          /* mov al, 0x1f */
            ii(0x1019_9b7d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_9b7f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_9b81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_9b83, 2); mov(ah, 0xfa);                          /* mov ah, 0xfa */
            ii(0x1019_9b85, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9b87, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1019_9b89, 1); popd(es);                               /* pop es */
            ii(0x1019_9b8a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_9b8b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_9b8c, 1); retd(); return;                         /* ret */
        l_0x1019_9b8d:
            ii(0x1019_9b8d, 7); cmp(memb_a32[ds, 0x101c_1c40], 0);      /* cmp byte [0x101c1c40], 0x0 */
            ii(0x1019_9b94, 2); if(jzd(0x1019_9bb1, 0x1b)) goto l_0x1019_9bb1; /* jz 0x10199bb1 */
            ii(0x1019_9b96, 4); mov(bl, memb_a32[es, eax + 0x40]);      /* mov bl, [es:eax+0x40] */
            ii(0x1019_9b9a, 4); mov(memb_a32[es, eax + 0x3e], dl);      /* mov [es:eax+0x3e], dl */
            ii(0x1019_9b9e, 3); and(bl, 0xfb);                          /* and bl, 0xfb */
            ii(0x1019_9ba1, 4); mov(memb_a32[es, eax + 0x40], bl);      /* mov [es:eax+0x40], bl */
            ii(0x1019_9ba5, 3); mov(eax, cr0);                          /* mov eax, cr0 */
            ii(0x1019_9ba8, 2); and(al, 0xfb);                          /* and al, 0xfb */
            ii(0x1019_9baa, 3); mov(cr0, eax);                          /* mov cr0, eax */
            ii(0x1019_9bad, 2); mov(ah, 0x30);                          /* mov ah, 0x30 */
            ii(0x1019_9baf, 2); @int(0x21);                             /* int 0x21 */
        l_0x1019_9bb1:
            ii(0x1019_9bb1, 2); xor(al, al);                            /* xor al, al */
            ii(0x1019_9bb3, 1); popd(es);                               /* pop es */
            ii(0x1019_9bb4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_9bb5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_9bb6, 1); retd(); return;                         /* ret */
        }
    }
}
